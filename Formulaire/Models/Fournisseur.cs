using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Formulaire.Models
{
    public class Fournisseur
    {
        public int Id { get; set; }
        public string NomF { get; set; }
        public virtual List<Article> Articles { get; set; }
    }
}