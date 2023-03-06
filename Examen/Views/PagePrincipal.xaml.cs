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
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private async void tooladd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageCont());
        }

        private async void toollist_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageList());
        }

        private async void toolmap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageMap());
        }
    }
}