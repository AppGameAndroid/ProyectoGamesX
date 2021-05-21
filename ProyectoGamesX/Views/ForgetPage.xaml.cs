using ProyectoGamesX.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoGamesX.Views
{
    
    public partial class ForgetPage : ContentPage
    {
        public ForgetPage()
        {
            InitializeComponent();
            this.BindingContext = new ForgetViewModel();
        }
    }
}