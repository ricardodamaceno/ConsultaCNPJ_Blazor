using Newtonsoft.Json;

namespace ConsultaCNPJ.Model
{
    public class ConsultaCnpjResponse
    {
        [JsonProperty("abertura")]
        public string Abertura { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }

        [JsonProperty("tipo")]
        public string Tipo { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("fantasia")]
        public string Fantasia { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("uf")]
        public string UF { get; set; }

        [JsonProperty("cep")]
        public string CEP { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("telefone")]
        public string Telefone { get; set; }
        
        [JsonProperty("cnpj")]
        public string CNPJ { get; set; }
    }
}
