using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Srez.BD;
using System.IO;

namespace Srez
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "srez.db";
        public static TableRepos database;
        public static TableRepos Database
        {
            get
            {
                if (database == null)
                {
                    database = new TableRepos(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
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
