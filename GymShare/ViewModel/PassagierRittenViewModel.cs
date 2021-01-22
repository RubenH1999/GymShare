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
    class PassagierRittenViewModel: BaseViewModel
    {
        private DialogService dialogService;

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
                RitUserDataService ru = new RitUserDataService();
                if(selectedRit != null)
                {
                    Chauffeur = ru.GetChauffeur(SelectedRit.RitId);
                }
                
                NotifyPropertyChanged();
            }
        }

        private User chauffeur;
        public User Chauffeur
        {
            get
            {
                return chauffeur;
            }
            set
            {
                chauffeur = value;
                NotifyPropertyChanged();
            }
        }

        public PassagierRittenViewModel()
        {

            //opsplitsen naar chauffeur ritten & passagier ritten
            Messenger.Default.Register<ObservableCollection<RitUser>>(this, OnPassagierRittenReceived);

            uitschrijvenCommand = new BaseCommand(Uitschrijven);


            //instantiëren DialogService als singleton
            dialogService = new DialogService();
        }
        private void OnPassagierRittenReceived(ObservableCollection<RitUser> ritten)
        {
            PassagierRitten = ritten;

        }

        private ICommand uitschrijvenCommand;
        public ICommand UitschrijvenCommand
        {
            get
            {
                return uitschrijvenCommand;
            }

            set
            {
                uitschrijvenCommand = value;
            }
        }

        private void Uitschrijven()
        {
            RitUserDataService ru = new RitUserDataService();
            ru.Uitschrijven(SelectedRit);
            RitDataService rd = new RitDataService();
            SelectedRit.Rit.Zetels++;
            rd.UpdateRit(SelectedRit.Rit);
            
        }
    }
}
