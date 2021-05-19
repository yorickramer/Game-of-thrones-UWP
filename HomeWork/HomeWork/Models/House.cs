﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{

    //család adattároló osztály
    class House
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string CoatOfArms { get; set; }
        public string Words { get; set; }
        public string[] Titles { get; set; }
        public string[] Seats { get; set; }
        public string CurrentLord { get; set; }
        public string Heir { get; set; }
        public string Overlord { get; set; }
        public string Founded { get; set; }
        public string Founder { get; set; }
        public string DiedOut { get; set; }
        public string[] AncestralWeapons { get; set; }
        public string[] CadetBranches { get; set; }
        public string[] SwornMembers { get; set; }

        public string CurrentLordName { get; set; }
        public string HeirName { get; set; }
        public string FounderName { get; set; }

    }
}
