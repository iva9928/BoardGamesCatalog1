using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;

namespace BoardGamesCatalog.Controllers
{
    /// <summary>
    /// Base controller that provides common functionality for other controllers.
    /// </summary>
    public class BaseController : Controller
    {
        /// <summary>
        /// Retrieves the currently authenticated user's ID.
        /// </summary>
        /// <returns>The user ID as a string, or null if not authenticated.</returns>
        protected string GetUserId()
        {
            return User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}
