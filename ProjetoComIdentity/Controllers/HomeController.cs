using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoComIdentity.Models;

namespace ProjetoComIdentity.Controllers
{
    //Com esse codigo no início da contoller, eu restrinjo todas as views dessa controller, mas posso escolher uma específica
    [Authorize(Policy ="SomenteGestores")]
    public class HomeController : Controller
    {
        // com esse comando acima de método específico, pode restringir apenas essa para os usuários definidos na policy
        // na classe 'Startup'
       // [Authorize(Policy = "SomenteGestores")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
