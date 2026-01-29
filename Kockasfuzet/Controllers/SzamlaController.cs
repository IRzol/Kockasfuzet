using Kockasfuzet.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockasfuzet.Controllers
{
    internal class SzamlaController
    {
        public List<Szamla> GetSzamlaList()
        {
            MySqlConnection connection = new MySqlConnection();
            string connectionString = "SERVER=localhost;DATABASE=kockasfuzet;UID=root;PASSWORD=;";
            connection.ConnectionString = connectionString;
            connection.Open();
            string sql = "SELECT * FROM szamla";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Szamla> eredmeny = new List<Szamla>();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                eredmeny.Add(new Szamla()
                {
                    Id = reader.GetInt32("Id"),
                    Szolgaltatoazon = reader.GetInt32("SzolgaltatasAzon"),
                    Szolgaltatorovid = reader.GetString("SzolgaltatoRovid"),
                    Tol = reader.GetDateTime("Tol"),
                    Ig = reader.GetDateTime("Ig"),
                    Osszeg =reader.GetInt32("Osszeg"),
                    Hatarido = reader.GetDateTime("Hatarido"),
                    Befizetve = reader.GetDateTime("Befizetve"),
                    Megjegyzes = reader.GetString("Megjegyzes")


                });
            }
            connection.Close();
            return eredmeny;
        }
    }
}
