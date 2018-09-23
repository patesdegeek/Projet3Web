using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projet3Web.Models
{
    public abstract class Personne
    {
        public int Id { get; set; }
        public string Civilite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public DateTime DateNaissance { get; set; }

        [NotMapped]
        public int Age

        {
            get
            {
                return DateTime.Now.Date.Subtract(DateNaissance).Days / 365;
            }
        }
    }
}