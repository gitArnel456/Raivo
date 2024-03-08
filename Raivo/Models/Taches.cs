using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raivo.Models
{
    public class Taches
    {
        private int _tacheid;
        private string _nomutilisateur;
        private string _description;
        private bool _etat;

        public int Tacheid { get => _tacheid; set => _tacheid = value; }
        public string Nomutilisateur { get => _nomutilisateur; set => _nomutilisateur = value; }
        public string Description { get => _description; set => _description = value; }
        public bool Etat { get => _etat; set => _etat = value; }

        public Taches(int tacheid, string nomutilisateur, string description, bool etat)
        {
            _tacheid = tacheid;
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

        public Taches()
        {

        }
    }
}