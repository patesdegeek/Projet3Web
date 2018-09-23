using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet3Web.Models
{
    public enum EtatDossierReservation
    {
        EnAttente = 0,
        EnCours   = 1,
        Refusee   = 2,
        Acceptee  = 3
    }
}