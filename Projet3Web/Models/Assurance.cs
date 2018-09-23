using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet3Web.Models
{
    public class Assurance
    {
        public int Id { get; set; }
        public decimal Montant { get; set; }
        public TypeAssurance Type { get; set; }
    }
}