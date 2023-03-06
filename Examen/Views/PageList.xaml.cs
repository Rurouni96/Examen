using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageList : ContentPage
    {
        public PageList()
        {
            InitializeComponent();

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listcont.ItemsSource = await App.dbcont.Listacontactos();

        }

        private void listcont_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void toolopc_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageOpc());
        }
    }

}