using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace projetomobrj
{
    class MainClass
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepCliente = RestService.For<ICepApiService>("http://viacep.com.br");
                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando Informacoes do CEP:" + cepInformado);

                var address = await cepCliente.GetAddressAsync(cepInformado);
                Console.Write($"\nLogradouro:{address.Logadouro}\nBairro:{address.Bairro}\nCidade:{address.Localidade}\nIbge:{address.Ibge}\nGia:{address.Gia}");

                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Erro na consulto de Cep");
            }

        }
    }
}