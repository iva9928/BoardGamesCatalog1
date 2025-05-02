using BoardGamesCatalog.NewFolder;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCatalog.Controllers
{
    /// <summary>
    /// Home controller responsible for rendering the main entry point of the application.
    /// </summary>
    public class HomeController : BaseController
    {
        /// <summary>
        /// Displays the home page. If the user is authenticated, redirects to BoardGames index.
        /// </summary>
        /// <returns>The home view or a redirect to BoardGames/Index if logged in.</returns>
        [AllowAnonymous]
        public IActionResult Index()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "BoardGames");
            }
            return View();
        }

        /// <summary>
        /// Displays the error page with request tracking information.
        /// </summary>
        /// <returns>Error view with request ID.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
