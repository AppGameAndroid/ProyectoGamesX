using ProyectoGamesX.ViewModels;
using ProyectoGamesX.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProyectoGamesX
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(ForgetPage), typeof(ForgetPage));
            Routing.RegisterRoute(nameof(VideoJuegosPage), typeof(VideoJuegosPage));

        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
