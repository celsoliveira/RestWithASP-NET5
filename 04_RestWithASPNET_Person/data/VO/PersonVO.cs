using System.Text.Json.Serialization;

namespace RestWithASPNET.data.VO
{

    public class PersonVO
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        // [JsonIgnore] ignora o campo na serialização
        public string Address { get; set; }

        //[JsonPropertyName("sex")] mudando o nome
        public string Gender { get; set; }

    }
}
