using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoGamesX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Favoritepage : ContentPage
    {
        public Favoritepage()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked2(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//VideojuegosPage");
        }


        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new VJPop());
        }
    }
}