using Dapper;
using GymShare.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymShare.Model
{
    class ProfielDataService
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;

        // Aanmaken van een object uit de IDbConnection class en instantiëren van een SqlConnection.
        // Dit betekent dat de connectie met de database automatisch geopend wordt.
        private static IDbConnection db = new SqlConnection(connectionString);

        public User GetProfiel(int userID)
        {
            //int UserID = Convert.ToInt32(App.Current.Properties["UserID"]);
            
            
            
            // Uitschrijven SQL statement & bewaren in een string. 
            string sql = "Select * FROM [dbo].[User] WHERE Id = @userID";
            

            //Uitvoeren SQL statement op db instance 
            //Type casten van het generieke return type naar een collectie van contactpersonen
            User profiel = db.QueryFirstOrDefault<User>(sql, new { userID });
            
            return profiel;
        }

        public void UpdateUser(User user)
        {
            // SQL statement update 
            string sql = "Update User set firstname = @firstname, lastname = @lastname, email=@email, phone= @phone where id = 6";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new { user.Firstname, user.Lastname,user.Email,user.Phone ,user.ID });
        }


    }
}
