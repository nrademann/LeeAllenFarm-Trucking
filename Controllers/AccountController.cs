using LeeAllenFarmAndTrucking.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LeeAllenFarmAndTrucking.Controllers
{
    public class AccountController : Controller
    {
        private ClientDbContext db;
        private UserManager<ClientInfo> userManager;
        private SignInManager<ClientInfo> signInManager;
        private RoleManager<IdentityRole> roleManager;
        public AccountController(UserManager<ClientInfo> userManager,
            SignInManager<ClientInfo> signInManager,
            RoleManager<IdentityRole> roleManager,
            ClientDbContext db)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.db = db;
        }
        [Authorize]
        public IActionResult Login()
        {
            return View();
        }
    }

}
