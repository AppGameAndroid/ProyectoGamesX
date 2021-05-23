
using Xamarin.CommunityToolkit.UI.Views;
using ProyectoGamesX.ViewModels;
using Xamarin.Forms.Xaml;

namespace ProyectoGamesX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VJPop : Popup
    {
        public VJPop()
        {
            InitializeComponent();
            BindingContext = new VideojuegosViewModel();
        }
    }
}