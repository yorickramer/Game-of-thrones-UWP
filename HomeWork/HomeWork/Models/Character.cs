using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum gender
{
    Male,
    Female
}

namespace HomeWork.Models
{
    //karakter adattároló osztály
    class Character
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public gender Gender { get; set; }
        public string Culture { get; set; }
        public string Born { get; set; }
        public string Died { get; set; }
        public string[] Titles { get; set; }
        public string[] Aliases { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        public string Spouse { get; set; }
        public string[] Allegiances { get; set; } //to Houses URL
        public string[] Books { get; set; } //to books url
        public string[] PovBooks { get; set; }
        public string[] TvSeries { get; set; }
        public string[] playedBy { get; set; }

        public string fatherName { get; set; }
        public string motherName { get; set; }
        public string spouseName { get; set; }

    }
}
