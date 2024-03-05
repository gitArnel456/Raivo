using Npgsql;
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
    }
}