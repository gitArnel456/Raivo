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

    }
}[]