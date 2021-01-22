using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymShare.Model
{
    class RitUserDataService
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;

        // Aanmaken van een object uit de IDbConnection class en instantiëren van een SqlConnection.
        // Dit betekent dat de connectie met de database automatisch geopend wordt.
        private static IDbConnection db = new SqlConnection(connectionString);

        public void InsertRitUser(Rit rit, User user)
        {
            
            int ritid = rit.ID;
            int userid = user.ID;
            // SQL statement delete 
            string sql = "INSERT RitUser(TypeId,userid,RitId) values (1,@UserId,@RitId)";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new {  userid,ritid });
        }

        public void InsertPassagier(Rit rit, User user)
        {
            int ritid = rit.ID;
            int userid = user.ID;
            // SQL statement delete 
            string sql = "INSERT RitUser(TypeId,userid,RitId) values (2,@UserId,@RitId)";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new { userid, ritid });
        }

        public ObservableCollection<RitUser> GetChauffeurRitten(User user)
        {
            
            // Uitschrijven SQL statement & bewaren in een string. 
            string sql = "Select* from RitUser inner join Rit on RitUser.RitId = Rit.Id inner join Gym on Rit.GymId = Gym.Id inner join[dbo].[User] on RitUser.UserId = [dbo].[User].Id where RitUser.UserId = " + user.ID + " AND RitUser.TypeId = 1 AND Rit.Datum >= CONVERT(date,GETDATE())";

            var ritten = db.Query<RitUser, Rit, Gym, User, RitUser>(sql, (ritUser, rit, gym, gebruiker) =>
            {
                ritUser.User = gebruiker;
                ritUser.Rit = rit;
                ritUser.Rit.Gym = gym;

                return ritUser;
            },
           splitOn: "Id,Id,Id");
            //Uitvoeren SQL statement op db instance 
            //Type casten van het generieke return type naar een collectie van contactpersonen
            Debug.WriteLine("doet het?");
            return new ObservableCollection<RitUser>((List<RitUser>)ritten);
        }

        public ObservableCollection<RitUser> GetPassagierRitten(User user)
        {

            // Uitschrijven SQL statement & bewaren in een string. 
            string sql = "Select* from RitUser inner join Rit on RitUser.RitId = Rit.Id inner join Gym on Rit.GymId = Gym.Id inner join[dbo].[User] on RitUser.UserId = [dbo].[User].Id where RitUser.UserId = " + user.ID + " AND RitUser.TypeId = 2 AND Rit.Datum >= CONVERT(date,GETDATE())";

            var ritten = db.Query<RitUser, Rit, Gym, User, RitUser>(sql, (ritUser, rit, gym, gebruiker) =>
            {
                ritUser.User = gebruiker;
                ritUser.Rit = rit;
                ritUser.Rit.Gym = gym;

                return ritUser;
            },
           splitOn: "Id,Id,Id");
            //Uitvoeren SQL statement op db instance 
            //Type casten van het generieke return type naar een collectie van contactpersonen
            Debug.WriteLine("doet het?");
            return new ObservableCollection<RitUser>((List<RitUser>)ritten);
        }

        public ObservableCollection<RitUser> GetPassagiers(int ritid)
        {
            

            string sql = "Select* from RitUser inner join Rit on RitUser.RitId = Rit.Id inner join[dbo].[User] on RitUser.UserId = [dbo].[User].Id where  RitUser.TypeId =2  and Rit.Id = " + ritid +";";


            var ritten = db.Query<RitUser, Rit, User, RitUser>(sql,(ritUser, ritje,  gebruiker) =>
            {
                ritUser.User = gebruiker;
                
                

                return ritUser;
            },
           splitOn: "Id,Id,Id");
            //Uitvoeren SQL statement op db instance 
            //Type casten van het generieke return type naar een collectie van contactpersonen
            Debug.WriteLine("doet het?");
            return new ObservableCollection<RitUser>((List<RitUser>)ritten);
        }

        public User GetChauffeur(int ritid)
        {
            

            string sql = "Select* from RitUser inner join Rit on RitUser.RitId = Rit.Id inner join[dbo].[User] on RitUser.UserId = [dbo].[User].Id where  RitUser.TypeId =1  and Rit.Id = " + ritid;

            var chauffeur = db.QueryFirstOrDefault<User>(sql);

            return chauffeur;


            
        }
        public void Uitschrijven(RitUser ritUser)
        {
            string sql = "Delete RitUser where userId = @userId and ritId = @ritId and typeId = 2";

            db.Execute(sql, new { ritUser.UserId, ritUser.RitId });
        }

        public void VerwijderRit(RitUser ritUser)
        {
                        
            string sql = "Delete RitUser where RitUser.RitId = @ritId ;Delete Rit where Rit.Id = " + ritUser.RitId;

            db.Execute(sql, new { ritUser.RitId});
        }


    }
}
