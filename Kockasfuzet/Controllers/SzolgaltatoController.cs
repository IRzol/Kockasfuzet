using Kockasfuzet.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockasfuzet.Controllers
{
    internal class SzolgaltatoController
    {
        public List<Szolgaltato> GetSzolgaltatoList()
        {
            MySqlConnection connection = new MySqlConnection();
            string connectionString = "SERVER=localhost;DATABASE=kockasfuzet;UID=root;PASSWORD=;";
            connection.ConnectionString = connectionString;
            connection.Open();
            string sql = "SELECT * FROM szolgaltato";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Szolgaltato> eredmeny = new List<Szolgaltato>();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                eredmeny.Add(new Szolgaltato()
                {
                    RovidNev = reader.GetString("RovidNev"),
                    Nev = reader.GetString("Nev"),
                    Ugyfelszolgalat = reader.GetString("Ugyfelszolgalat")
                });
            }
            connection.Close();
            return eredmeny;
        }
    }
}
