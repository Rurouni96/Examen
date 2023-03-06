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
    public partial class PageCont : ContentPage
    {
        public PageCont()
        {
            InitializeComponent();
        }

        private async void btnagregar_Clicked(object sender, EventArgs e)
        {
            var cont = new Models.Contactos
            {
                Nombres = txtnombres.Text,
                Apellidos = txtapellidos.Text,
                Edad = Convert.ToInt32(txtedad.Text),
                Pais = txtpais.Text,
                Nota = txtnota.Text
            };

            if (await App.dbcont.StoreCont(cont) > 0)
            {
                await DisplayAlert("Aviso", "Registro ingresado con exito", "OK");
            }

            txtnombres.Text = "";
            txtapellidos.Text = "";
            txtedad.Text = "";
            txtpais.Text = "";
            txtnota.Text = "";

        }
    }
}