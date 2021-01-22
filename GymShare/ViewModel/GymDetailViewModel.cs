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
    class GymDetailViewModel : BaseViewModel
    {

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

        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public GymDetailViewModel()
        {
            
            Messenger.Default.Register<Gym>(this, OnGymReceived);


            UpdateCommand = new BaseCommand(UpdateGym);
            DeleteCommand = new BaseCommand(DeleteGym);

        }

        private void DeleteGym()
        {
            GymDataService ds = new GymDataService();
            ds.DeleteGym(SelectedGym);

            Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage(UpdateFinishedMessage.MessageType.Deleted));

        }

        private void UpdateGym()
        {

            GymDataService ds = new GymDataService();

            if (SelectedGym.ID != 0)
            {
                ds.UpdateGym(SelectedGym);

                Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage(UpdateFinishedMessage.MessageType.Updated));
            }
            else
            {
                ds.InsertGym(SelectedGym);

                Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage(UpdateFinishedMessage.MessageType.Inserted));
            }
        }
        

       


        private void OnGymReceived(Gym gym)

        {
            SelectedGym = gym;
        }
    }
}
