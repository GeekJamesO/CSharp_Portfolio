using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("contact")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
