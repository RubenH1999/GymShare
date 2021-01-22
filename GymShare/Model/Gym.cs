using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymShare.Model
{
    public class Gym : BaseModel
    {
        private int id;
        private string naam;
        private string sport;
        private ICollection<Rit> ritten;

        public Gym()
        {

        }

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

        public string Naam
        {
            get
            {
                return naam;
            }

            set
            {
                naam = value;
                NotifyPropertyChanged();
            }
        }

        public string Sport
        {
            get
            {
                return sport;
            }

            set
            {
                sport = value;
                NotifyPropertyChanged();
            }
        }

        public ICollection<Rit> Ritten
        {
            get { return ritten; }
            set
            {
                ritten = value;
                NotifyPropertyChanged();
            }
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
