using Kockasfuzet.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockasfuzet.Controllers
{
    internal class SzolgaltatasController
    {
        public List<Szolgaltatas> GetSzolgaltatasList()
        {
            MySqlConnection connection = new MySqlConnection();
            string connectionString = "SERVER=localhost;DATABASE=kockasfuzet;UID=root;PASSWORD=;";
            connection.ConnectionString = connectionString;
            connection.Open();
            string sql = "SELECT * FROM szolgaltatas";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Szolgaltatas> eredmeny = new List<Szolgaltatas>();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                eredmeny.Add(new Szolgaltatas()
                {
                    Id = reader.GetInt16("Id"),
                    Nev = reader.GetString("Nev")
                });
            }
            connection.Close();
            return eredmeny;
        }
    }
}
