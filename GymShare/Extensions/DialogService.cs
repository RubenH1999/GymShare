using GymShare.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GymShare.Extensions
{
    public class DialogService
    {
        Window ritDetailView = null;
        Window gymDetailView = null;
        Window profielView = null;        
        Window adminDashboardView = null;
        Window gebruikerDashboardView = null;
        Window nieuweRitView = null;
        Window beschikbareRittenView = null;
        Window mijnRittenView = null;
        Window registerView = null;
        Window passagierRittenView = null;
        Window loginWindow = null;
        public DialogService() { }

        public void ShowDetailDialog()
        {
            ritDetailView = new RitDetailWindow();
            ritDetailView.ShowDialog();
        }

        public void CloseDetailDialog()
        {
            if (ritDetailView != null)
                ritDetailView.Close();
        }

        public void ShowGymDetailDialog()
        {
            gymDetailView = new GymDetailWindow();
            gymDetailView.ShowDialog();
        }

        public void ShowProfielDialog()
        {
            profielView = new ProfielWindow();
            profielView.ShowDialog();
        }

        public void ShowAdminDashboardDialog()
        {
            adminDashboardView = new AdminDashboardWindow();
            adminDashboardView.ShowDialog();
        }

        public void ShowGebruikersDashboardDialog()
        {
            gebruikerDashboardView = new GebruikerDashboardWindow();
            gebruikerDashboardView.ShowDialog();
        }

        public void ShowNieuweRitDialog()
        {
            nieuweRitView = new NieuweRitWindow();
            nieuweRitView.ShowDialog();
        }

        public void ShowBeschikbareRittenDialog()
        {
            beschikbareRittenView = new BeschikbareRittenWindow();
            beschikbareRittenView.ShowDialog();
        }

        public void ShowMijnRittenDialog()
        {
            mijnRittenView = new MijnRittenWindow();
            mijnRittenView.ShowDialog();
        }
        
        public void ShowRegisterDialog()
        {
            registerView = new RegisterWindow();
            registerView.ShowDialog();
        }

        public void ShowPassagierRittenDialog()
        {
            passagierRittenView = new PassagierRittenWindow();
            passagierRittenView.ShowDialog();
        }

        public void ShowLoginWindow()
        {
            loginWindow = new LoginWindow();
            passagierRittenView.ShowDialog();
        }
    }
}
