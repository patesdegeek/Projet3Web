using Projet3Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projet3Web.Controllers
{
    public class ClientsController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetClients()
        {
            return Ok(new Client[] {
                new Client {Id=1, Civilite = "Mr", Nom = "Parrot", Prenom = "Laurent", Email = "kestounet@gmail.com", Adresse = "11, Caserne des Gardes 78120 Rambouillet", DateNaissance = DateTime.Parse("05/09/1983"), Telephone = "0648091132"},
                new Client {Id=2, Civilite = "Mme", Nom = "Parrot", Prenom = "Anne", Email = "patesdegeek@gmail.com", Adresse = "11, Caserne des Gardes 78120 Rambouillet", DateNaissance = DateTime.Parse("13/07/1982"), Telephone = "0123456789"}
            });
        }
    }
}
