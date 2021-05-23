using System;

using ProyectoGamesX.ViewModels;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

using Xamarin.CommunityToolkit.Extensions;

namespace ProyectoGamesX.Views
{
   
    public partial class VideoJuegosPage : ContentPage
    {
        public VideoJuegosPage()
        {
            InitializeComponent();
            BindingContext = new VideojuegosViewModel();
        }



        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new VJPop());
        }
    }
}