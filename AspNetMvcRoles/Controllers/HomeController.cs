using System.Diagnostics;
using System.Security.Claims;
using AspNetMvcRoles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetMvcRoles.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager; //herda IdentityUser
        private readonly RoleManager<IdentityRole> _roleManager;

        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            criarRole();
            return View();
        }

        //criar regra para usuario
        public async void criarRole()
        {
            if (User.Identity.IsAuthenticated)
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin")); // cria regra
                var user = await _userManager.GetUserAsync(HttpContext.User); /// pegar usuario                                                          // 
                await _userManager.AddToRoleAsync(user, "Admin"); //colocar regra e usuario

                _logger.LogInformation("Login Criado com Sucesso");
            }
        }
        //fim criar regra 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
