using Npgsql;
using Raivo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Raivo.Models
{
    public class DBConnection
    {
        public static NpgsqlConnection connectionstring = new NpgsqlConnection
            (ConfigurationManager.ConnectionStrings["tacheDBConnection"].ConnectionString);

        public static bool verifylogin(Login login)
        {
            var req = "SELECT \"nomutilisateur\", \"motdepasse\" FROM public.\"login\" WHERE \"nomutilisateur\"='" + login.Nomutilisateur + "' AND \"motdepasse\"= '" + login.Motdepasse + "';";
            var hasUser = false;
            try
            {
                connectionstring.Open();
                var cmd = new NpgsqlCommand(req, connectionstring);
                var reader = cmd.ExecuteReader();
                hasUser = reader.HasRows;
                connectionstring.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return hasUser;
       }

        public void ajouterUtilisateur(Inscription inscription)
        {
            var req = $"INSERT INTO public.inscription(nom_prenom, nomutilisateur, motdepasse) VALUES ('{inscription.Nom_prenom}'," +
                $" '{inscription.Nomutilisateur}', '{inscription.Motdepasse}')";
            try
            {
                connectionstring.Open();
                var cmd = new NpgsqlCommand(req, connectionstring);
                cmd.ExecuteNonQuery();
                connectionstring.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void createTaches(Taches taches)
        {
            var req = $"INSERT INTO public. taches(nomutilisateur,description,state) VALUES" +
                $" ('{taches.Nomutilisateur}','{taches.Description}','{taches.Etat}')";
            try
            {
                connectionstring.Open();
                var cmd = new NpgsqlCommand(req,connectionstring);
                cmd.ExecuteNonQuery();
                connectionstring.Close();
            }catch (Exception e)
            {
                throw e;
            }
        }

        public void deleteTaches(Taches taches)
        {
            var req = $"DELETE FROM public.taches WHERE id = { taches.Id }; ";
            try
            {
                connectionstring.Open();
                var cmd = new NpgsqlCommand(req, connectionstring);
                cmd.ExecuteNonQuery();
                connectionstring.Close();
            }catch(Exception e)
            {
                throw e;
            }
        }

        public void updateTaches(Taches taches)
        {
            var req = $"UPDATE public.taches SET nomutilisateur = { taches.Nomutilisateur }, " +
                $"description = { taches.Description }, etat = { taches.Etat} WHERE id = { taches.Id }; ";
            try
            {
                connectionstring.Open();
                var cmd = new NpgsqlCommand(req, connectionstring);
                cmd.ExecuteNonQuery();
                connectionstring.Close();
            }catch (Exception e) { throw e; }
        }

        public static List<Taches> displayTaches(string nomutilisateur)
        {
            var req = $"SELECT * FROM public.taches WHERE nomutilisateur ={nomutilisateur}";
            var taches = new List<Taches>();
            try
            {
                connectionstring.Open();
                var cmd = new NpgsqlCommand(req, connectionstring);
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    var tache = new Taches(rd.GetInt32(0),rd.GetString(1),rd.GetString(2),rd.GetBoolean(4));
                    taches.Add(tache);
                }
                connectionstring.Close();
            }catch(Exception e) { throw e; }
            return taches;
        }

    }
}





   