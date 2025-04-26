using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;

namespace BoardGamesCatalog.Controllers
{
    public class BaseController : Controller
    {
        protected string GetUserId()
        {
            return User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}
