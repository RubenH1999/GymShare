using GymShare.Extensions;
using GymShare.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GymShare.ViewModel
{
    class RegisterViewModel: BaseViewModel
    {
        private DialogService dialogService;

        private User user;
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

        public RegisterViewModel()
        {
            user = new User();
            RegisterCommand = new BaseCommand(Registreren);
        }

        private ICommand registerCommand;
        public ICommand RegisterCommand
        {
            get
            {
                return registerCommand;
            }

            set
            {
                registerCommand = value;
            }
        }

        private void Registreren()
        {
            LoginDataService ds = new LoginDataService();

            if(ds.Registreer(User) != null)
            {
               
                Debug.WriteLine("Registratie succesvol");

            }
            else
            {
                Debug.WriteLine("Registratie mislukt");
            }
        }
    }
}
