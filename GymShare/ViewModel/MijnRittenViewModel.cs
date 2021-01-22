using GymShare.Extensions;
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
    class MijnRittenViewModel: BaseViewModel
    {
        private DialogService dialogService;

        private ObservableCollection<RitUser> chauffeurRitten;

        public ObservableCollection<RitUser> ChauffeurRitten
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

        private ObservableCollection<RitUser> passagiers;

        public ObservableCollection<RitUser> Passagiers
        {
            get
            {
                return passagiers;
            }
            set
            {
                passagiers = value;
                NotifyPropertyChanged();
            }
        }

        private ICommand getPassagiersCommand;
        public ICommand GetPassagiersCommand
        {
            get
            {
                return getPassagiersCommand;
            }

            set
            {
                getPassagiersCommand = value;
            }
        }

        private ICommand verwijderRitCommand;
        public ICommand VerwijderRitCommand
        {
            get
            {
                return verwijderRitCommand;
            }

            set
            {
                verwijderRitCommand = value;
            }
        }

        private ICommand updateRitCommand;
        public ICommand UpdateRitCommand
        {
            get
            {
                return updateRitCommand;
            }

            set
            {
                updateRitCommand = value;
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
                if(SelectedRit != null) { 
                Passagiers = ru.GetPassagiers(SelectedRit.RitId);
                }
                NotifyPropertyChanged();
            }
        }

        public MijnRittenViewModel()
        {

            //opsplitsen naar chauffeur ritten & passagier ritten
            Messenger.Default.Register<ObservableCollection<RitUser>>(this,OnChauffeurRittenReceived);

            verwijderRitCommand = new BaseCommand(VerwijderRit);
            updateRitCommand = new BaseCommand(UpdateRit);

            //instantiëren DialogService als singleton
            dialogService = new DialogService();
        }
        private void OnChauffeurRittenReceived(ObservableCollection<RitUser> ritten)
        {
            ChauffeurRitten = ritten;
            
        }
        private void VerwijderRit()
        {
            RitUserDataService ru = new RitUserDataService();
            ru.VerwijderRit(SelectedRit);
            
            
        }

        private void UpdateRit()
        {
            RitDataService rd = new RitDataService();
            rd.UpdateRit(SelectedRit.Rit);
        }

        

        

    }
}
