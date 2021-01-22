using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymShare.Extensions;
using System.Reactive.Linq;
using System.Diagnostics;

namespace GymShare.Model
{
    class RitDataService
    {
        // Ophalen ConnectionString uit App.config
        private static string connectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;

        // Aanmaken van een object uit de IDbConnection class en instantiëren van een SqlConnection.
        // Dit betekent dat de connectie met de database automatisch geopend wordt.
        private static IDbConnection db = new SqlConnection(connectionString);


        public ObservableCollection<Rit> GetRitten()
        {
            // Uitschrijven SQL statement & bewaren in een string. 
            string sql = "Select * FROM Rit Inner join Gym ON Rit.GymId = Gym.Id where Rit.zetels > 0 AND Rit.Datum >= CONVERT(date,GETDATE()) ORDER BY Uur";

            var ritten = db.Query<Rit, Gym, Rit>(sql, (rit, gym) =>
            {
                rit.Gym = gym;
                return rit;
            },
           splitOn: "Id");
            //Uitvoeren SQL statement op db instance 
            //Type casten van het generieke return type naar een collectie van contactpersonen
            return new ObservableCollection<Rit>((List<Rit>)ritten);
        }

        public void UpdateRit(Rit rit)
        {
            // SQL statement update 
            string sql = "Update Rit set gymId = @gymId, zetels = @zetels, uur = @uur, datum = @datum where id = @id";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new { rit.GymId, rit.Zetels, rit.Uur,rit.Datum, rit.ID });
        }

        public void DeleteRit(Rit rit)
        {
            // SQL statement delete nog aanpassen zodat eerst de rituser wordt verwidjerd en dan pas de rit
            string sql =
                "Delete RitUser where RitId = @id ;Delete Rit where Id = @id";
                


            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new { rit.ID });
        }

        public void InsertRit(Rit rit)
        {
            // SQL statement delete 
            string sql = "Insert Rit(gymId,zetels,uur) values(@gymId,@zetel,@uur)";

            // Uitvoeren SQL statement en doorgeven parametercollectie
            db.Execute(sql, new { rit.GymId,rit.Zetels, rit.Uur});
        }

        public Rit NieuweRit(Rit rit)
        {
            string sql = "Insert Rit(gymId,zetels,uur, datum)OUTPUT INSERTED.id values(@gymId,@zetels,@uur, @datum)";
            rit = db.QueryFirstOrDefault<Rit>(sql, new { rit.GymId, rit.Zetels, rit.Uur, rit.Datum });
            return rit;
        }

        
        

        
    }
}
