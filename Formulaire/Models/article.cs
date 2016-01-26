using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Formulaire.Models
{
    public class Article
    {
        public int Id { get; set; } 
        public string Nom { get; set; }
        public virtual Fournisseur Fournisseur {get; set;}
    }
}