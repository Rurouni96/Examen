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
    public partial class PageActualizar : ContentPage
    {
        public PageActualizar()
        {
            InitializeComponent();
        }

        private async void btnactualizar_Clicked(object sender, EventArgs e)
        {
            var cont = new Models.Contactos
            {
                Id = Convert.ToInt32(txtcodigo.Text),

                Nombres = txtnombres.Text,
                Apellidos = txtapellidos.Text,
                Edad = Convert.ToInt32(txtedad.Text),
                Pais = txtpais.Text,
                Nota = txtnota.Text
            };

            await App.dbcont.StoreCont(cont);

            await DisplayAlert("Aviso", "Registro Actualizado con exito", "OK");

            await Navigation.PushAsync(new Views.PageList());

        }
    }
}