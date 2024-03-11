using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raivo.Models
{
    public class Taches
    {
        private int _id;
        private string _nomutilisateur;
        private string _description;
        private bool _etat;

        public int Id { get => _id; set => _id = value; }
        public string Nomutilisateur { get => _nomutilisateur; set => _nomutilisateur = value; }
        public string Description { get => _description; set => _description = value; }
        public bool Etat { get => _etat; set => _etat = value; }

        public Taches(int id, string nomutilisateur, string description, bool etat)
        {
            _id = id;
            _nomutilisateur = nomutilisateur;
            _description = description;
            _etat = etat;
        }
        public Taches(string nomutilisateur, string description, bool etat)
        {
            _nomutilisateur = nomutilisateur;
            _description = description;
            _etat = etat;
        }

        public Taches(string description, bool etat)
        {
            _description = description;
            _etat = etat;
        }

        public Taches()
        {

        }

        public Taches(int id)
        {
            _id = id;
        }
    }
}