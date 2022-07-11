using Microsoft.AspNetCore.Identity;

namespace LeeAllenFarm_Trucking.Models
{
    public class ClientInfo : IdentityUser
    {
        public int clientId { get; set; }
        public string clientName { get; set; }
        public string phoneNum { get; set; }
        public string emailAddress { get; set; }
        public string homeAddress { get; set; }
        public string deliveryAddress { get; set; }
        public string comment { get; set; } 
    }
}
