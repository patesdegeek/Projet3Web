using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projet3Web.Models
{
    [Table("AgencesVoyages")]
    public class AgenceVoyage
    {
        public int Id { get; set; }
        public string Nom { get; set; }
    }
}