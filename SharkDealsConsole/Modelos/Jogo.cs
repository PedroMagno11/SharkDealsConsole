using System.Text.Json.Serialization;

namespace SharkDealsConsole.Modelos
{
    internal class Jogo
    {
        [JsonPropertyName("title")]
        public string? Nome { get; set; }

        [JsonPropertyName("salePrice")]
        public string? PrecoDeVenda { get; set; }
        [JsonPropertyName("normalPrice")]
        public string? PrecoNormal { get; set; }

        [JsonPropertyName("savings")]
        public string? Desconto { get; set; }

       
        public override string ToString()
        {
            return $"Nome: {this.Nome}\nPreço sem desconto: {this.PrecoNormal}\nPreço com desconto: {this.PrecoDeVenda}\nDesconto de: {this.Desconto!.Substring(0,5)}%\n";
        }
    }
}
