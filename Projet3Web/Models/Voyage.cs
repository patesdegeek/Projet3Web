using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projet3Web.Models
{
    public class Voyage
    {
        public int Id { get; set; }

        public int IdAgenceVoyage { get; set; }
        [ForeignKey("IdAgenceVoyage")]
        public virtual AgenceVoyage AgenceVoyage { get; set; }

        public int IdDestination { get; set; }
        [ForeignKey("IdDestination")]
        public virtual Destination Destination { get; set; }

        public DateTime DateAller { get; set; }
        public DateTime DateRetour { get; set; }
        public int PlacesDisponibles { get; set; }
        public decimal PrixParPersonne { get; set; }


        public static void Reserver(int places) { }

        public decimal CalculMarge()
        {
            return PrixParPersonne + (0.1m * PrixParPersonne);
        }
    }
}