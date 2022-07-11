using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace LeeAllenFarmAndTrucking.Models
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
