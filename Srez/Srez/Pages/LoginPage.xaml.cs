using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Srez.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public ICommand NavRegistPageCommand => new Command(NavRegistPage);

        private async void NavRegistPage()
        {
            await Navigation.PushAsync(new RegistPage());
        }
        private void btnLoginClicked(object sender, EventArgs e)
        {
            var user = App.Database.GetUsers().Where(u => u.Login == loginEntry.Text && u.Password == passwordEntry.Text).ToList().FirstOrDefault();
            if (user != null)
            {
                Navigation.PushAsync(new ProjectsPage(user));
            }
            else
            {
                DisplayAlert("Ошибка", "Неверные данные", "ОК");
            }
        }
    }
}