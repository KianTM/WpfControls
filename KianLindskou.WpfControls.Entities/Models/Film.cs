﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KianLindskou.WpfControls.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Land { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int Oscars { get; set; }
    }
}
