using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class HeroRepository
    {
        const string CONNECTION_STRING = @"Data Source=DESKTOP-FIRM\SQLEXPRESS;Initial Catalog=SuperHero;Integrated Security=True";

        public List<HeroBasic> GetAllHeroes()
        {
            var heros = new List<HeroBasic>();
            using (SqlConnection heroConnection = new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "select * from Hero";
                command.Connection = heroConnection;

                heroConnection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    heros.Add(new HeroBasic()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                    });
                }
            }
            return heros;
        }

        public Hero GetHero(int heroId)
        {
            var hero = new Hero();
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "Select * from hero where id = @heroId";
                command.Connection = connection;

                connection.Open();

                command.Parameters.AddWithValue("@heroId", heroId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    hero.Id = (int)reader["Id"];
                    hero.Name = reader["Name"].ToString();
                    hero.NumOfKills = (int)reader["NumOfKills"];
                }
            }

            return hero;
        }
    }
}
