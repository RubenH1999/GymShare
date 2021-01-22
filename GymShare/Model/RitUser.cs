using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymShare.Model
{
   public class RitUser: BaseModel
    {
        private int id;
        private int typeId;
        private int userId;
        private int ritId;
        private Rit rit;
        private User user;


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

        public int TypeId
        {
            get
            {
                return typeId;
            }

            set
            {
                typeId = value;
                NotifyPropertyChanged();
            }
        }

        public int UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
                NotifyPropertyChanged();
            }
        }

        public int RitId
        {
            get
            {
                return ritId;
            }

            set
            {
                ritId = value;
                NotifyPropertyChanged();
            }
        }

        public User User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
                NotifyPropertyChanged();
            }
        }

        public Rit Rit
        {
            get
            {
                return rit;
            }

            set
            {
                rit = value;
                NotifyPropertyChanged();
            }
        }

        public RitUser(int iD, int typeId, int userId, int ritId, User user, Rit rit)
        {
            ID = iD;
            TypeId = typeId;
            UserId = userId;
            RitId = ritId;
            User = user;
            Rit = rit;
        }

        public RitUser()
        {
        }
    }
}
