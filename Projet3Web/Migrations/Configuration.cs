namespace Projet3Web.Migrations
{
    using Projet3Web.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Projet3Web.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Projet3Web.Data.ApplicationDbContext context)
        {
            context.Clients.AddOrUpdate(x => x.Id,
                new Client() { Civilite = "Mr", Nom = "Parrot", Prenom = "Laurent", Adresse = "11, Caserne des Gardes 78120 Rambouillet", Email = "kestounet@gmail.com", Telephone = "0648091132", DateNaissance = DateTime.Parse("05/09/1983") },
                new Client() { Civilite = "Mme", Nom = "Parrot", Prenom = "Anne", Adresse = "11, Caserne des Gardes 78120 Rambouillet", Email = "patesdegeek@gmail.com", Telephone = "0123456789", DateNaissance = DateTime.Parse("13/07/1982") },
                new Client() { Civilite = "Mme", Nom = "Bauduin", Prenom = "Edith", Adresse = "11, Rue de nulle part 59000 Pamplume", Email = "e.b@gmail.com", Telephone = "9876543210", DateNaissance = DateTime.Parse("20/03/1970") }
            );
        }
    }
}
