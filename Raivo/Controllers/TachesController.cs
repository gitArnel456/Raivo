using Raivo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Raivo.Controllers
{
    public class TachesController : Controller
    {
        // GET: Taches


        public class TacheController : Controller
        {
            public ActionResult ListeTache()
            {

                string nomUtilisateur = Session["Nomutilisateur"].ToString();

                DBConnection.retrouverTaches(nomUtilisateur);
                return View(DBConnection.retrouverTaches("nomUtilisateur"));
            }

            public ActionResult Modifier(int id)
            {
                return Content($"<h4> Ressource numéro : {id} </h4>");
            }
        }

        public ActionResult taches()
        {
            return View();
        }

        public ActionResult ajouterTaches(Taches taches)
        {
            DBConnection connection = new DBConnection();
            connection.ajouterUtilisateur(taches);

            return View("taches");
        }
    }
}