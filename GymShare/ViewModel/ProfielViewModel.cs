using GymShare.Extensions;
using GymShare.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymShare.ViewModel
{
    public class ProfielViewModel: BaseViewModel
    {

        private DialogService dialogService;



        public ProfielViewModel()
        {
            dialogService = new DialogService();
            Messenger.Default.Register<User>(this, OnUserReceived);

            

        }

        private User profiel;
        public User Profiel
        {
            get
            {
                return profiel;
            }
            set
            {
                profiel = value;
                NotifyPropertyChanged();
            }
        }

        private void OnUserReceived(User user)
        {
            Profiel = user;
        }
    }
}
