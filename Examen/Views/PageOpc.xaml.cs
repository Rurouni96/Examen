using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageOpc : ContentPage
    {
        public PageOpc()
        {
            InitializeComponent();
        }

        private async void btninsertar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageCont());
        }

        private async void btnactualizar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageActualizar());
        }

        private async void btneliminar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageElim());
        }

        private async void btninicio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PagePrincipal());
        }
    }
}