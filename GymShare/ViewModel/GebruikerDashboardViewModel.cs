using GymShare.Extensions;
using GymShare.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GymShare.ViewModel
{
    class GebruikerDashboardViewModel: BaseViewModel
    {
        private DialogService dialogService;

        private ICommand profielCommand;
        public ICommand ProfielCommand
        {
            get
            {
                return profielCommand;
            }

            set
            {
                profielCommand = value;
            }
        }

        private ICommand nieuweRitCommand;
        public ICommand NieuweRitCommand
        {
            get
            {
                return nieuweRitCommand;
            }

            set
            {
                nieuweRitCommand = value;
            }
        }
        private ICommand beschikbareRittenCommand;
        public ICommand BeschikbareRittenCommand
        {
            get
            {
                return beschikbareRittenCommand;
            }

            set
            {
                beschikbareRittenCommand = value;
            }
        }

        private ICommand mijnRittenCommand;
        public ICommand MijnRittenCommand
        {
            get
            {
                return mijnRittenCommand;
            }

            set
            {
                mijnRittenCommand = value;
            }
        }

        private ICommand passagierRittenCommand;
        public ICommand PassagierRittenCommand
        {
            get
            {
                return passagierRittenCommand;
            }

            set
            {
                passagierRittenCommand = value;
            }
        }

        public GebruikerDashboardViewModel()
        {
            Messenger.Default.Register<User>(this, OnUserReceived);
            dialogService = new DialogService();

            
            nieuweRitCommand = new BaseCommand(NieuweRit);
            beschikbareRittenCommand = new BaseCommand(BeschrikbareRitten);
            mijnRittenCommand = new BaseCommand(MijnRitten);
            passagierRittenCommand = new BaseCommand(GetPassagierRitten);
        }

        

        private void NieuweRit()
        {
            dialogService.ShowNieuweRitDialog();
        }

        private void BeschrikbareRitten()
        {
            dialogService.ShowBeschikbareRittenDialog();
        }

        private void MijnRitten()
        {

            RitUserDataService ds = new RitUserDataService();
            chauffeurRitten = ds.GetChauffeurRitten(CurrentUser);
            
            Messenger.Default.Send(chauffeurRitten);
            
            dialogService.ShowMijnRittenDialog();
        }

        private void GetPassagierRitten()
        {
            RitUserDataService ru = new RitUserDataService();

            PassagierRitten = ru.GetPassagierRitten(CurrentUser);
            Messenger.Default.Send(passagierRitten);
            dialogService.ShowPassagierRittenDialog();
        }

        private void OnUserReceived(User user)
        {
            CurrentUser = user;
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

        private ObservableCollection<RitUser> chauffeurRitten;

        public ObservableCollection<RitUser> ChaufeurRitten
        {
            get
            {
                return chauffeurRitten;
            }
            set
            {
                chauffeurRitten = value;
                NotifyPropertyChanged();
            }
        }
        private ObservableCollection<RitUser> passagierRitten;
        public ObservableCollection<RitUser> PassagierRitten
        {
            get
            {
                return passagierRitten;
            }
            set
            {
                passagierRitten = value;
                NotifyPropertyChanged();
            }
        }

        private RitUser selectedRit;
        public RitUser SelectedRit
        {
            get
            {
                return selectedRit;
            }
            set
            {
                selectedRit = value;
                NotifyPropertyChanged();
            }
        }
    }
}
