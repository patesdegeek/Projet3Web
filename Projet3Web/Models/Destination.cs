﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet3Web.Models
{
    public class Destination
    {
        public int Id { get; set; }
        public string Continent { get; set; }
        public string Pays { get; set; }
        public string Region { get; set; }
        public string Description { get; set; }
    }
}