using Formulaire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formulaire.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateArticle()
        {
            IDal dal = new Dal();
            Article article = new Article();
            ViewBag.ListeDesFournisseurs = new SelectList(dal.getAllFournisseurs(), "Id", "NomF");
            return View(article);
        }
        [HttpPost]
        public ActionResult CreateArticle(Article article)
        {
           IDal dal = new Dal();
           Fournisseur fournisseur =  dal.getFournisseurById(Int32.Parse(Request.Form["Fournisseur"]));
           dal.CreateArticle(article.Nom, fournisseur);
           return View(article);
        }

        public ActionResult ListArticle()
        {
            return View();
        }
        public ActionResult ReadArticle(int id)
        {
            return View();
        }
        public ActionResult CreateFournisseur()
        {

            Fournisseur fournisseur = new Fournisseur();

            return View(fournisseur);
        }
        [HttpPost]
        public ActionResult CreateFournisseur(Fournisseur fournisseur)
        {
            IDal dal = new Dal();
            dal.CreateFournisseur(fournisseur.NomF);
 
            return View();
        }
        public ActionResult ListFournisseur()
        {
            IDal dal = new Dal();
            List<Fournisseur> fournisseurs = dal.getAllFournisseurs();

            return View(fournisseurs);
        }
        public ActionResult ReadFournisseur(int id)
        {
            return View();
        }
    }
}