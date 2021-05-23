using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoGamesX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Configuraciones : ContentPage
    {
        public Configuraciones()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.DisplayAlert(
                    "OK",
                    "Cambios Guardados.",
                    "Accept");
        }
    }
}