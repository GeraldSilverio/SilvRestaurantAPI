using System.Text.Json.Serialization;

namespace SilvRestaurant.Core.Application.Dtos
{
    public class AuthenticationResponse
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public List<string> Roles { get; set; }
        public bool HasError { get; set; }
        public string? Error { get; set; }
        public string JWToken { get; set; }
        [JsonIgnore]
        public string RefreshToken { get; set; }
    }
}
