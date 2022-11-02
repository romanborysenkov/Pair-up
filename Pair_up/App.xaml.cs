using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pair_up.Data;
using System.IO;

namespace Pair_up
{
    public partial class App : Application
    {
        static MembersDB membersdb;

        public static MembersDB MembersDB
        {
            get
            {
                if(membersdb == null)
                {
                    membersdb = new MembersDB(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "MembersDatabase.db3"));
                }
                return membersdb;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
