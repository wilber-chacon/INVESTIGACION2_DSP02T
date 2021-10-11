using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVVM.Models;

namespace MVVM.Controllers
{
    public class HomeController : Controller
    {
        //comando para mostrar la pagina de inicio
        public IActionResult Index()
        {
            return View();
        }

        //comando para mostrar la pagina sobre MVC y MVVM
        public IActionResult MVC_y_MVVM()
        {
           
            return View();
        }
        //comando para mostrar la pagina sobre los Comandos Principales y Diseño de Interfaces
        public IActionResult ComandosPrincipales()
        {

            return View();
        }

        //comando para mostrar la pagina de Quienes somos
        public IActionResult Nosotros()
        {

            return View();
        }


        //comando para mostrar la pagina de utilidad
        public IActionResult Utilidad()
        {

            return View();
        }


        //comando para mostrar la pagina de comandos y diseño
        public IActionResult Comandos_y_Diseño()
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
