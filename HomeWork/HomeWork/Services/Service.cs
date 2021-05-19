using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Models;

namespace HomeWork.Services
{
    class Service
    {
        private readonly Uri serverUrl = new Uri("https://www.anapioficeandfire.com");

        //generikus metódus, ami a System.Net.HttpClient osztály segítségével végrehajt 
        //egy GET kérést aszinkron módon, majd az eredményt a kapott JSONból visszasorosítja.
        private async Task<T> GetAsync<T>(Uri uri)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                var json = await response.Content.ReadAsStringAsync();
                T result = JsonConvert.DeserializeObject<T>(json);
                return result;
            }
        }

        //aszinkron metódus ami egy adott ID-jü Book objektumot ad vissza
        public async Task<Book> GetBookAsync(int id)
        {
            return await GetAsync<Book>(new Uri(serverUrl, $"api/books/{id}"));
        }


        //aszinkron metódus ami egy adott ID-jü House objektumot ad vissza
        public async Task<House> GetHouseAsync(int id)
        {
            var h =  await GetAsync<House>(new Uri(serverUrl, $"api/houses/{id}"));
            if (h.CurrentLord != "")
            {
                var lord = await GetAsync<Character>(new Uri(serverUrl, $"api/characters/{GetID(h.CurrentLord)}"));
                h.CurrentLordName = lord.Name;
            }
            else
            {
                h.CurrentLordName = "Unknown";
            }

            if (h.Heir != "")
            {
                var heir = await GetAsync<Character>(new Uri(serverUrl, $"api/characters/{GetID(h.Heir)}"));
                h.HeirName = heir.Name;
            }
            else
            {
                h.HeirName = "Unknown";
            }

            if (h.Founder != "")
            {
                var founder = await GetAsync<Character>(new Uri(serverUrl, $"api/characters/{GetID(h.Founder)}"));
                h.FounderName = founder.Name;
            }
            else
            {
                h.FounderName = "Unknown";
            }

            return h;
        }

        //aszinkron metódus ami egy adott ID-jü Character objektumot ad vissza
        public async Task<Character> GetCharacterAsync(int id)
        {
            var character =  await GetAsync<Character>(new Uri(serverUrl, $"api/characters/{id}"));

            if(character.Father != "")
            {
                var father = await GetAsync<Character>(new Uri(serverUrl, $"api/characters/{GetID(character.Father)}"));
                character.fatherName = father.Name;
            }
            else
            {
                character.fatherName = "Unknown";
            }


            if (character.Mother != "")
            {
                var mother = await GetAsync<Character>(new Uri(serverUrl, $"api/characters/{GetID(character.Mother)}"));
                character.motherName = mother.Name;
            }
            else
            {
                character.motherName = "Unknown";
            }

            if (character.Spouse != "")
            {
                var spouse = await GetAsync<Character>(new Uri(serverUrl, $"api/characters/{GetID(character.Spouse)}"));
                character.spouseName = spouse.Name;
            }
            else
            {
                character.spouseName = "Unknown";
            }

            return character;
        }

        //aszinkron metódus ami egy adott ID-jü Character objektumot ad vissza
        public async Task<Character> GetCharacterAsync(string id)
        {
            return await GetAsync<Character>(new Uri(id));
        }


        //aszinkron metódus ami pagesize méretű, page oldalú <List<Book> ad vissza
        public async Task<List<Book>> GetBooksAsync(int page, int pagesize)
        {
            return await GetAsync<List<Book>>(new Uri(serverUrl, "api/books?page=" + page.ToString()+ "&pageSize=" + pagesize.ToString()));
        }


        //aszinkron metódus ami pagesize méretű, page oldalú <List<Character> ad vissza
        public async Task<List<Character>> GetCharactersAsync(int page, int pagesize)
        {
            return await GetAsync<List<Character>>(new Uri(serverUrl, "api/characters?page=" + page.ToString() + "&pageSize=" + pagesize.ToString()));
        }


        //aszinkron metódus ami pagesize méretű, page oldalú <List<House> ad vissza
        public async Task<List<House>> GethousesAsync(int page, int pagesize)
        {
            return await GetAsync<List<House>>(new Uri(serverUrl, "api/houses?page=" + page.ToString() + "&pageSize=" + pagesize.ToString()));
        }


        //aszinkron metódus ami az összes Book objektumot <List<Book>>-ként adja vissza
        public async Task<List<Book>> GetAllBooksAsync()
        {
            int page = 1;
            List<Book> newBook = await GetBooksAsync(page, 50);
            List<Book> allbooks = new List<Book>();
            while (newBook.Count == 50)
            {
                for (int i = 0; i < newBook.Count; i++)
                {
                    allbooks.Add(newBook[i]);
                }
                page++;
                newBook = await GetBooksAsync(page, 50);
            }

            for(int i = 0; i < newBook.Count; i++)
            {
                allbooks.Add(newBook[i]);
            }

            return allbooks;
        }


        //aszinkron metódus ami az összes Character objektumot <List<Character>>-ként adja vissza
        public async Task<List<Character>> GetAllCharactersAsync()
        {
           

            int page = 1;
            List<Character> newCharacter = await GetCharactersAsync(page, 50);
            List<Character> allChar = new List<Character>();
            while (newCharacter.Count == 50)
            {
                for (int i = 0; i < newCharacter.Count; i++)
                {
                    allChar.Add(newCharacter[i]);
                }
                page++;
                newCharacter = await GetCharactersAsync(page, 50);
            }

            for (int i = 0; i < newCharacter.Count; i++)
            {
                allChar.Add(newCharacter[i]);
            }

            return allChar;
        }


        //aszinkron metódus ami az összes House objektumot <List<House>>-ként adja vissza
        public async Task<List<House>> GetAllHousesAsync()
        {
            int page = 1;
            List<House> newHouse = await GethousesAsync(page, 50);
            List<House> oldHouse = new List<House>();
            while (newHouse.Count == 50)
            {
                for (int i = 0; i < newHouse.Count; i++)
                {
                    oldHouse.Add(newHouse[i]);
                }
                page++;
                newHouse = await GethousesAsync(page, 50);
            }

            for (int i = 0; i < newHouse.Count; i++)
            {
                oldHouse.Add(newHouse[i]);
            }

            return oldHouse;
        }


        //A kapott url-ből kiszedi az ID-t, ami az utolsó / utáni szám, és ezzel tér vissza
        public int GetID(string url)
        {
            string[] words = url.Split('/');
            int len = words.Length;
            return Int32.Parse(words[len - 1]);
        }

    }

}
