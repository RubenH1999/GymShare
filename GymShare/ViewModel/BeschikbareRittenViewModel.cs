using GymShare.Extensions;
using GymShare.Messages;
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
    class BeschikbareRittenViewModel: BaseViewModel
    {
        private DialogService dialogService;

        private ObservableCollection<Rit> ritten;

        public ObservableCollection<Rit> Ritten
        {
            get
            {
                return ritten;
            }
            set
            {
                ritten = value;
                NotifyPropertyChanged();
            }
        }

        private Rit selectedRit;
        public Rit SelectedRit
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

        public BeschikbareRittenViewModel()
        {
            RitDataService ds = new RitDataService();
            ritten = ds.GetRitten();
            Messenger.Default.Register<User>(this, OnUserReceived);

            //instantiëren DialogService als singleton
            dialogService = new DialogService();

            //koppelen commands
            DeelnemenCommand = new BaseCommand(DeelnemenRit);

            Messenger.Default.Register<UpdateFinishedMessage>(this, OnMessageReceived);

        }

        private ICommand deelnemenCommand;
        public ICommand DeelnemenCommand
        {
            get
            {
                return deelnemenCommand;
            }

            set
            {
                deelnemenCommand = value;
            }
        }

        private void DeelnemenRit()
        {
            if (SelectedRit != null)
            {
                RitUserDataService ru = new RitUserDataService();
                ru.InsertPassagier(SelectedRit, CurrentUser);
                //updaten aantal zetels --> enkel ritten tonen waar zetels meer dan 0 zijn
                RitDataService rd = new RitDataService();
                SelectedRit.Zetels--;
                rd.UpdateRit(SelectedRit);
            }
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

        private void OnMessageReceived(UpdateFinishedMessage message)
        {
            //na update of delete mag detailvenster sluiten
            

            //na Delete/Insert moet collectie Koffies terug ingeladen worden
            if (message.Type != UpdateFinishedMessage.MessageType.Updated)
            {
                RitDataService ds = new RitDataService();
                ritten = ds.GetRitten();
            }

        }
    }
}
