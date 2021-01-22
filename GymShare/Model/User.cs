using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymShare.Model
{
    public class User:BaseModel
    {
        private int id;
        private string email;
        private string password;
        private string firstname;
        private string lastname;
        private string phone;
        private int role;
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

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
                NotifyPropertyChanged();
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
                NotifyPropertyChanged();
            }
        }

        public int Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
                NotifyPropertyChanged();
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
                NotifyPropertyChanged();
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
                NotifyPropertyChanged();
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
                NotifyPropertyChanged();
            }
        }
        public  string GebruikerNaam()
        {
            return Firstname + " " + Lastname;
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

        

    }
}
