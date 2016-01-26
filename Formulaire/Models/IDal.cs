using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulaire.Models
{
    interface IDal : IDisposable
    {
        void CreateArticle(string nom , Fournisseur fournisseur);
        List<Article> getAllArticles();
        Article getArticleById(int id);

        void CreateFournisseur(string nom);
        List<Fournisseur> getAllFournisseurs();
        Fournisseur getFournisseurById(int id); 
    }
}
