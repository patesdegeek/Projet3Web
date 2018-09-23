using Projet3Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projet3Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("ApplicationConnectionString")
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}