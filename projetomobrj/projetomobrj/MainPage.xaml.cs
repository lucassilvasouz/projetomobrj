﻿using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
            //string cepInformado = Console.ReadLine().ToString();
            string cepInformado = "79104330";
            Console.WriteLine("Consultando Informacoes do CEP:" + cepInformado);

            var address = await cepCliente.GetAddressAsync(cepInformado);
            //Preferences.Set("logradouro", address.Logadouro);
            Console.Write($"\nLogradouro:{address.Logradouro}\nBairro:{address.Bairro}\nCidade:{address.Localidade}\nIbge:{address.Ibge}\nGia:{address.Gia}");

            await Navigation.PushAsync(new mapa(cepInformado));
        }    
    
    }
}
