using GymShare.Extensions;
using GymShare.Messages;
using GymShare.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GymShare.ViewModel
{
    class NieuweRitViewModel: BaseViewModel
    {

        private DialogService dialogService;



        public NieuweRitViewModel()
        {
            dialogService = new DialogService();
            Messenger.Default.Register<User>(this, OnUserReceived);
            rit = new Rit();
            selectedGym = new Gym();
            GymDataService gymDataService = new GymDataService();
            Gyms = gymDataService.GetGyms();
            toevoegenCommand = new BaseCommand(NieuweRit);

        }

        private User currentUser;
        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
                NotifyPropertyChanged();
            }
        }

        private ObservableCollection<Gym> gyms;
        public ObservableCollection<Gym> Gyms
        {
            get
            {
                return gyms;
            }

            set
            {
                gyms = value;
                NotifyPropertyChanged();
            }
        }

        private Gym selectedGym { get; set; }
        public Gym SelectedGym
        {
            get
            {
                return selectedGym;
            }

            set
            {
                selectedGym = value;
                NotifyPropertyChanged();
            }
        }

        private Rit rit;
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

        private void OnUserReceived(User user)
        {
            CurrentUser = user;
        }

        private void NieuweRit()
        {
            Rit.GymId = SelectedGym.ID;
            RitDataService ds = new RitDataService();
            Rit = ds.NieuweRit(Rit);
            
            if (Rit != null )
            {
                
                
                Debug.WriteLine("Nieuwe rit aanmaken gelukt");
                RitUserDataService ru = new RitUserDataService();
                ru.InsertRitUser(Rit, CurrentUser);
                Messenger.Default.Send<Rit>(Rit);
            }
            else
            {
                Debug.WriteLine(Rit.ID);
            }
        }

        private ICommand toevoegenCommand;
        public ICommand ToevoegenCommand
        {
            get
            {
                return toevoegenCommand;
            }

            set
            {
                toevoegenCommand = value;
            }
        }


    }
}
