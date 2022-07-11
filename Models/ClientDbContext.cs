using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace LeeAllenFarm_Trucking.Models
{
    public class ClientDbContext :
        IdentityDbContext<ClientInfo>
    {
        public ClientDbContext(DbContextOptions
            <ClientDbContext> options)
            : base(options)
        { 
        }
    }
}
