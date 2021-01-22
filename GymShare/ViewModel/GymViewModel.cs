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
    class GymViewModel:BaseViewModel
    {
        private DialogService dialogService;

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

        private Gym selectedGym;
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

        private ICommand wijzigenCommand;
        public ICommand WijzigenCommand
        {
            get
            {
                return wijzigenCommand;
            }

            set
            {
                wijzigenCommand = value;
            }
        }



        public GymViewModel()
        {
            //laden data
            GymDataService ds = new GymDataService();
            gyms = ds.GetGyms();

            //instantiëren DialogService als singleton
            dialogService = new DialogService();

            //koppelen commands
            WijzigenCommand = new BaseCommand(WijzigenGym);
            ToevoegenCommand = new BaseCommand(ToevoegenGym);

            //luisteren naar messages vanuit detailvenster
            Messenger.Default.Register<UpdateFinishedMessage>(this, OnMessageReceived);

        }

        private void ToevoegenGym()
        {
            SelectedGym = new Gym();

            Messenger.Default.Send<Gym>(SelectedGym);

            dialogService.ShowGymDetailDialog();

        }

        private void OnMessageReceived(UpdateFinishedMessage message)
        {
            //na update of delete mag detailvenster sluiten
            dialogService.CloseDetailDialog();

            //na Delete/Insert moet collectie Koffies terug ingeladen worden
            if (message.Type != UpdateFinishedMessage.MessageType.Updated)
            {
                GymDataService ds = new GymDataService();
                Gyms = ds.GetGyms();
            }

        }

        private void WijzigenGym()
        {
            if (SelectedGym != null)
            {
                Messenger.Default.Send<Gym>(SelectedGym);

                dialogService.ShowGymDetailDialog();
            }
        }
    }
}
