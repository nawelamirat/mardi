using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Formulaire.Models
{
    public class Dal : IDal
    {
        private BddContext Bdd;

        public Dal()
        {
            Bdd = new BddContext();
        }

        public void CreateArticle(string nom, Fournisseur fournisseur)
        {
            Bdd.Articles.Add( new Article { Nom = nom, Fournisseur = fournisseur } );
            Bdd.SaveChanges();
        }

        public void CreateFournisseur(string nom)
        {
            Bdd.Fournisseurs.Add(new Fournisseur {NomF = nom });
            Bdd.SaveChanges();
        }

        public void Dispose()
        {
            Bdd.Dispose();
        }

        public List<Article> getAllArticles()
        {
            return Bdd.Articles.ToList();
        }

        public List<Fournisseur> getAllFournisseurs()
        {
            return Bdd.Fournisseurs.ToList();
        }

        public Article getArticleById(int id)
        {
            return Bdd.Articles.FirstOrDefault( article => article.Id == id);
        }

        public Fournisseur getFournisseurById(int id )
        {
            return Bdd.Fournisseurs.FirstOrDefault( fournisseur => fournisseur.Id == id);
            
        }
    }
}