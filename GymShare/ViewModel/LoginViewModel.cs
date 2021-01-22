using GymShare.Extensions;
using GymShare.Messages;
using GymShare.Model;
using GymShare.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GymShare.ViewModel
{
    class LoginViewModel:BaseViewModel
    {

        private DialogService dialogService;

        private User selectUser;
        public User SelectUser
        {
            get
            {
                return this.selectUser;
            }
            set
            {
                selectUser = value;
                NotifyPropertyChanged();
            }
        }

        

        private ICommand loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                return loginCommand;
            }

            set
            {
                loginCommand = value;
            }
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

        public LoginViewModel()
        {
            SelectUser = new User();

            //instantiëren DialogService als singleton
            dialogService = new DialogService();

            //koppelen commands
            LoginCommand = new BaseCommand(AuthenticateUser);
            RegisterCommand = new BaseCommand(Register);

            
        }

        private void Register()
        {
            dialogService.ShowRegisterDialog();
        }

        public void AuthenticateUser()
        {

            LoginDataService ds = new LoginDataService();

            


            
            



            if ( ds.AuthenticateUser(SelectUser) != null)
            {
                SelectUser = ds.AuthenticateUser(SelectUser);
                Messenger.Default.Send<User>(SelectUser);
                if (SelectUser.Role == 1)
                {                    
                    dialogService.ShowAdminDashboardDialog();
                }
                else
                {
                    dialogService.ShowGebruikersDashboardDialog();
                }
                
            }
            
            
            
        }


    }
}
