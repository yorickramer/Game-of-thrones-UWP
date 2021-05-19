using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    //Könyv adattároló osztály
    class Book
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string[] Authors { get; set; }
        public int numberOfPages { get; set; }
        public string Publisher { get; set; }
        public string Country { get; set; }
        public string MediaType { get; set; }
        public string Released { get; set; }
        public string[] Characters { get; set; }
        public string[] PovCharacters { get; set; }
    }
}
