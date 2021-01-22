using Dapper;
using GymShare.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymShare.Model
{
    class GymDataService
    {
        // Ophalen ConnectionString uit App.config
        private static string connectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;

        // Aanmaken van een object uit de IDbConnection class en instantiëren van een SqlConnection.
        // Dit betekent dat de connectie met de database automatisch geopend wordt.
        private static IDbConnection db = new SqlConnection(connectionString);


        public ObservableCollection<Gym> GetGyms()
        {
            // Uitschrijven SQL statement & bewaren in een string. 
            string sql = "Select * FROM Gym order by naam";


            //Uitvoeren SQL statement op db instance 
            //Type casten van het generieke return type naar een collectie van contactpersonen
            ObservableCollection<Gym> gyms = db.Query<Gym>(sql).ToObservableCollection();
            Debug.WriteLine(gyms);
            return gyms;
        }

        public void UpdateGym(Gym gym)
        {
            // SQL statement update 
            string sql = "Update Gym set naam = @naam, sport = @sport where id = @id";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new { gym.Naam, gym.Sport, gym.ID });
        }

        public void DeleteGym(Gym gym)
        {
            // SQL statement delete 
            string sql =
                "Delete Gym where id = @id";



            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new { gym.ID });
        }

        public void InsertGym(Gym gym)
        {
            // SQL statement delete 
            string sql = "Insert Gym(naam,sport) values(@sport,@naam)";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new { gym.Naam, gym.Sport});
        }
    }
}
