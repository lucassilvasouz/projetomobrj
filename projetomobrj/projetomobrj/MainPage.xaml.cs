using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
//using projetomobrj.CepResponse;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace projetomobrj
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var cepCliente = RestService.For<ICepApiService>("http://viacep.com.br");
            string cepInformado = cepDigitado.Text;

            var address = await cepCliente.GetAddressAsync(cepInformado);
            //Preferences.Set("logradouro", address.Logadouro);
            logradouro.Text = $"Logradouro: {address.Logradouro}"; 
            bairro.Text = $"Bairro: {address.Bairro}"; 
            localidade.Text = $"Cidade: {address.Localidade}";
            ibge.Text = $"IBGE: {address.Ibge}";
            gia.Text= $"Gia: {address.Gia}";
        }

        private async void botaoMapa_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new mapa());
        }
    }
}
