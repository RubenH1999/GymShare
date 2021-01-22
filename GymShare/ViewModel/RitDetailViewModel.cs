using GymShare.Messages;
using GymShare.Model;
using GymShare.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace GymShare.ViewModel
{
    public class RitDetailViewModel: BaseViewModel
    {
        

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
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public RitDetailViewModel()
        {
            GymDataService gymDataService = new GymDataService();
            Gyms = gymDataService.GetGyms();
            Messenger.Default.Register<Rit>(this, OnRitReceived);

            
            UpdateCommand = new BaseCommand(UpdateRit);
            DeleteCommand = new BaseCommand(DeleteRit);

        }

        private void DeleteRit()
        {
            RitDataService ds = new RitDataService();
            ds.DeleteRit(SelectedRit);

            Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage(UpdateFinishedMessage.MessageType.Deleted));

        }

        private void UpdateRit()
        {

            RitDataService ds = new RitDataService();

            if (SelectedRit.ID != 0)
            {
                ds.UpdateRit(SelectedRit);

                Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage(UpdateFinishedMessage.MessageType.Updated));
            }
            else
            {
                ds.InsertRit(SelectedRit);

                Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage(UpdateFinishedMessage.MessageType.Inserted));
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


        private void OnRitReceived(Rit rit)

        {
            SelectedRit = rit;
        }

        
    }
}
