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
    public partial class PageElim : ContentPage
    {
        public PageElim()
        {
            InitializeComponent();
        }

        private async void btnelim_Clicked(object sender, EventArgs e)
        {
            var cont = new Models.Contactos
            {
                Id = Convert.ToInt32(txtcodigoId.Text)
            };

            await App.dbcont.Deletcontacto(cont);

            await DisplayAlert("Aviso", "Registro eliminado con exito", "OK");

            await Navigation.PushAsync(new Views.PageList());

        }
    }
}