using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projet3Web.Models
{
    [Table("DossiersReservations")]
    public class DossierReservation
    {


        public int Id { get; set; }

        public int IdClient { get; set; }
        [ForeignKey("IdClient")]
        public virtual Client Client { get; set; }

        public int IdParticipant { get; set; }
        [ForeignKey("IdParticipant")]
        public virtual Participant Participant { get; set; }

        public int IdVoyage { get; set; }
        [ForeignKey("IdVoyage")]
        public virtual Voyage Voyage { get; set; }

        public int? IdAssurance { get; set; }
        [ForeignKey("IdAssurance")]
        public virtual Assurance Assurance { get; set; }


        public int NumeroUnique { get; set; }

        [Required]
        public string NumeroCarteBancaire { get; set; }

        [Column("NombreParticipant")]
        public int NombreParticipant { get; set; }

        public decimal PrixParPersonne { get; set; }

        public decimal PrixTotal { get; set; }

        public EtatDossierReservation Etat { get; set; }

        public RaisonAnnulationDossier RaisonAnnulationDossier { get; set; }

        public static void Annuler(RaisonAnnulationDossier RRaisonAnnulationDossier)
        {

        }

        public static void ValiderSolvabilite()
        {

        }


        public void Accepter()
        {
            //Etat = EtatDossierReservation.Acceptee;
        }

        public void CalculerPrixTotal()
        {

            this.PrixTotal = ((this.PrixParPersonne * NombreParticipant));
        }

        //TODO : A revoir
        /* public void CalculerReductionAge()
         {
             decimal reduction = (40 / 100);
             this.PrixParPersonne = this.PrixParPersonne - this.PrixParPersonne * reduction;

         }*/
    }
}