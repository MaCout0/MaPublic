using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ContactWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projeto.Models;



namespace Projeto.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [Route("inicio/Registrar-se")]
        public ActionResult Create()
        {
            return View();
        }

        [Route("/")]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost("/")]
        public ActionResult Login(IFormCollection form)
        {
            User contato = new User();
            contato.name = form["name"];

            using (UserModel model = new UserModel())
            {
                contato.senha = model.codificaSenha(form["senha"]);
                int result = model.Login(contato);
                if (result != 0)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    return RedirectToAction("Create");
                }
            }

        }

        [HttpPost("inicio/enviaContato")]

        public ActionResult Create(IFormCollection form)
        {
            User contato = new User();
            contato.name = form["name"];
            contato.email = form["email"];

            using (UserModel model = new UserModel())
            {
                contato.senha = model.codificaSenha(form["senha"]);
                model.Create(contato);
                return RedirectToAction("Login");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
