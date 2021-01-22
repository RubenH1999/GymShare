using Dapper;
using GymShare.Extensions;
using GymShare.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GymShare.Model
{
    class LoginDataService
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;

        
        private static IDbConnection db = new SqlConnection(connectionString);
        

        public User AuthenticateUser(User user)
        {

            // SQL statement update 
            string sql = "SELECT * FROM [dbo].[User] WHERE Email=@email AND Password=@password";




            
             user = db.QueryFirstOrDefault<User>(sql, new { user.Email, user.Password });

            if (user != null)
            {
                Debug.WriteLine(user.Role);
                int role = user.Role;
                GlobalUser.UserID = user.ID;
                App.Current.Properties["UserID"] = user.ID;
                return user;
            }
            else
            {
                return null;
            }
            
            

            // Uitvoeren SQL statement en doorgeven parametercollectie



        }

        public User Registreer(User user)
        {
            string sql = "Insert [User] (firstname,lastname,email,phone,role,password) OUTPUT INSERTED.id values(@firstname,@lastname,@email,@phone,2, @password)";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            user = db.QueryFirstOrDefault<User>(sql, new { user.Firstname, user.Lastname, user.Email, user.Phone, user.Password });
            return user;
        }
    }
}
