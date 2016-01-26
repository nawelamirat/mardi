using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Formulaire.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
    }
}