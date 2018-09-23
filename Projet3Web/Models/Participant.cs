using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet3Web.Models
{
    public class Participant : Personne
    {
        public int NumeroUnique { get; set; }

        public float Reduction
        {
            get
            {
                if (Age < 12)
                    return 0.6f;

                else
                    return 1f;
            }
        }
    }
}