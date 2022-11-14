using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace projetomobrj
{
    public class CepResponse
    {

        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("logadouro")]
        public string Logadouro { get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("localidade")]
        public string Localidade { get; set; }
        [JsonProperty("uf")]
        public string Uf { get; set; }
        [JsonProperty("unidade")]
        public string Unidade { get; set; }
        [JsonProperty("ibge")]
        public string Ibge { get; set; }
        [JsonProperty("gia")]
        public string Gia { get; set; } 

    }
}
