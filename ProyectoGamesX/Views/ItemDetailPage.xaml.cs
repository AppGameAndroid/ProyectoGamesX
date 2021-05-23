using ProyectoGamesX.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProyectoGamesX.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}