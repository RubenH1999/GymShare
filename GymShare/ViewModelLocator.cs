using GymShare.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymShare
{
    class ViewModelLocator
    {
        private static  RitViewModel ritViewModel= new RitViewModel();
        private static RitDetailViewModel ritDetailViewModel = new RitDetailViewModel();
        private static GymViewModel gymViewModel = new GymViewModel();
        private static GymDetailViewModel gymDetailViewModel = new GymDetailViewModel();
        private static LoginViewModel loginViewModel = new LoginViewModel();
        private static ProfielViewModel profielViewModel = new ProfielViewModel();
        private static GebruikerDashboardViewModel gebruikerDashboardViewModel = new GebruikerDashboardViewModel();
        private static NieuweRitViewModel nieuweRitViewModel = new NieuweRitViewModel();
        private static BeschikbareRittenViewModel beschikbareRittenViewModel = new BeschikbareRittenViewModel();
        private static MijnRittenViewModel mijnRittenViewModel = new MijnRittenViewModel();
        private static RegisterViewModel registerViewModel = new RegisterViewModel();
        private static PassagierRittenViewModel passagierRittenViewModel = new PassagierRittenViewModel();

        public static RitViewModel RitViewModel
        {
            get
            {
                return ritViewModel;
            }
        }

        public static RitDetailViewModel RitDetailViewModel
        {
            get
            {
                return ritDetailViewModel;
            }
        }

        public static GymViewModel GymViewModel
        {
            get
            {
                return gymViewModel;
            }
        }

        public static GymDetailViewModel GymDetailViewModel
        {
            get
            {
                return gymDetailViewModel;
            }
        }
        public static LoginViewModel LoginViewModel
        {
            get
            {
                return loginViewModel;
            }
        }
        public static ProfielViewModel ProfielViewModel
        {
            get
            {
                return profielViewModel;
            }
        }

        public static GebruikerDashboardViewModel GebruikerDashboardViewModel
        {
            get
            {
                return gebruikerDashboardViewModel;
            }
        }

        public static NieuweRitViewModel NieuweRitViewModel
        {
            get
            {
                return nieuweRitViewModel;
            }
        }
        public static BeschikbareRittenViewModel BeschikbareRittenViewModel
        {
            get
            {
                return beschikbareRittenViewModel;
            }
        }

        public static MijnRittenViewModel MijnRittenViewModel
        {
            get
            {
                return mijnRittenViewModel;
            }
        }

        public static RegisterViewModel RegisterViewModel
        {
            get
            {
                return registerViewModel;
            }
        }

        public static PassagierRittenViewModel PassagierRittenViewModel
        {
            get
            {
                return passagierRittenViewModel;
            }
        }
    }
}
