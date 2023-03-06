using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen
{
    public partial class App : Application
    {
        static Controllers.DBCont dBCont;

        public static Controllers.DBCont dbcont 
        {
            get
            {
                if (dBCont == null)
                {
                    String DBName = "cont.db3";
                    String PathDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DBName);
                    dBCont = new Controllers.DBCont(PathDB);
                }

                return dBCont;

            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PagePrincipal());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
