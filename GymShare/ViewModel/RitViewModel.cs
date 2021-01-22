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
    public class RitViewModel: BaseViewModel
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



        public RitViewModel()
        {
            //laden data
            
            

            //instantiëren DialogService als singleton
            dialogService = new DialogService();

            //koppelen commands
            WijzigenCommand = new BaseCommand(WijzigenRit);
            ToevoegenCommand = new BaseCommand(ToevoegenRit);

            //luisteren naar messages vanuit detailvenster
            Messenger.Default.Register<UpdateFinishedMessage>(this, OnMessageReceived);

        }

        private void ToevoegenRit()
        {
            SelectedRit = new Rit();

            Messenger.Default.Send<Rit>(SelectedRit);

            dialogService.ShowDetailDialog();

        }

        private void OnMessageReceived(UpdateFinishedMessage message)
        {
            

        }

        private void WijzigenRit()
        {
            if (SelectedRit != null)
            {
                Messenger.Default.Send<Rit>(SelectedRit);

                dialogService.ShowDetailDialog();
            }
        }
    }
}
