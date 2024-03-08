using Raivo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Raivo.Controllers
{
    public class InscriptionController : Controller
    {
        // GET: Inscription
        public ActionResult Index()
        {
            return View();
        }
        
        public void ajouterUtilisateur(Login login)
        {
            DBConnection connection = new DBConnection();
            connection.ajouterUtilisateur(login);
        }
    }
}