using Raivo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Raivo.Controllers
{
    public class TachesController : Controller
    {
        // GET: Taches
            public ActionResult Tasks()
            {
            if (Session["username"] != null)
            {
                return View(DBConnection.retrouverTaches(Session["username"].ToString()));
            }
            else
            {
                // Gérer le cas où le nom d'utilisateur n'est pas défini dans la session
                // Par exemple, rediriger vers une page de connexion
                return RedirectToAction("Index");
            }
        }

            //public ActionResult Modifier(int id)
            //{
            //    return Content($"<h4> Ressource numéro : {id} </h4>");
            //}

        public ActionResult AjouterTaches(FormCollection form)
        {
            var tache = new Taches(Session["username"].ToString(), form["description"], form["etat"] == null ? false : true);
            DBConnection.AjouterTaches(tache);
            return RedirectToAction("Tasks");
        }
        public ActionResult Delete(int id)
        {
            try
            {
                DBConnection.deleteTaches(id);
                return RedirectToAction("Tasks");
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }
        public ActionResult Edit(FormCollection form)
        {
            var taches = new Taches("rabe","milalao be",true);
            DBConnection.updateTaches(9, taches);
            return RedirectToAction("Tasks");
            //return Content();
        }
    }
}