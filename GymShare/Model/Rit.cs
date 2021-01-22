using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymShare.Model
{
    public class Rit : BaseModel
    {
        private int id;
        private int gymId;
        private int zetels;        
        private TimeSpan uur;
        private DateTime datum;
        private Gym gym;
        private ICollection<RitUser> ritUsers;



        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                NotifyPropertyChanged();
            }
        }

        public int GymId
        {
            get
            {
                return gymId;
            }

            set
            {
                gymId = value;
                NotifyPropertyChanged();
            }
        }

        public int Zetels
        {
            get
            {
                return zetels;
            }

            set
            {
                zetels = value;
                NotifyPropertyChanged();
            }
        }

        public TimeSpan Uur
        {
            get
            {
                return uur;
            }

            set
            {
                uur = value;
                NotifyPropertyChanged();
            }
        }

        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
                NotifyPropertyChanged();
            }
        }

        public Gym Gym
        {
            get
            {
                return gym;
            }

            set
            {
                gym = value;
                NotifyPropertyChanged();
            }
        }

        public ICollection<RitUser> RitUsers
        {
            get { return ritUsers; }
            set
            {
                ritUsers = value;
                NotifyPropertyChanged();
            }
        }

        public Rit()
        {
        }

        public Rit(int iD, int gymId, int zetels, TimeSpan uur, DateTime datum)
        {
            ID = iD;
            GymId = gymId;
            Zetels = zetels;
            Uur = uur;
            Datum = datum;
        }
    }
}
