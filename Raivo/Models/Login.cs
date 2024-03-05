using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raivo.Models
{
    public class Login
    { 
        private int _id;
        private string _nomutilisateur;
        private string _motdepasse;

        public int Id { get => _id; set => _id = value; }
        public string Nomutilisateur { get => _nomutilisateur; set => _nomutilisateur = value; }
        public string Motdepasse { get => _motdepasse; set => _motdepasse = value; }

        public Login(int id, string nomutilisateur, string motdepasse)
        {
            _id = id;
            _nomutilisateur = nomutilisateur;
            _motdepasse = motdepasse;
        }
        public Login()
        {

        }
    }
}