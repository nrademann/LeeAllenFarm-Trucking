using LeeAllenFarmAndTrucking.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LeeAllenFarmAndTrucking
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var connection =
                @"Server=(localdb)\mssqllocaldb;Database=LeeAllenFarmAndTrucking;
                    Trusted_Connection=True;";
            services.AddDbContext<ClientDbContext>
                (options => options.UseSqlServer(connection));
            services.AddIdentity<ClientInfo, IdentityRole>()
                .AddEntityFrameworkStores<ClientDbContext>()
                .AddDefaultTokenProviders();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
