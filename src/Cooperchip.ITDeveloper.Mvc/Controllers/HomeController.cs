using Cooperchip.ITDeveloper.Mvc.Models;
using Cooperchip.ITDeveloper.Mvc.ViewModels;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Controllers
{
    [Route("")]
    [Route("gestao-de-paciente")]
    [Route("gestao-de-pacientes")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailSender _emailSender;

        public HomeController(IEmailSender emailSender, ILogger<HomeController> logger)
        {
            this._emailSender = emailSender;
            this._logger = logger;
        }

        [Route("")]
        [Route("pagina-inicial")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("dashboard")]
        [Route("pagina-de-estatistica")]
        public IActionResult Dashboard()
        {
            return View();
        }

        [Route("box-init")]
        public IActionResult BoxInit()
        {
            return View();
        }

        [HttpGet("fale-conosco")]
        //[Route("fale-conosco")]
        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        [Route("fale-conosco")]
        public async Task<IActionResult> Contato(ContatoViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _emailSender.SendEmailAsync(model.Email, model.Subject, model.Message);
                    _logger.Log(LogLevel.Information, message: "Email enviado com sucesso!");
                    return RedirectToAction("Index", controllerName: "Home");
                }
                catch (Exception e)
                {
                    _logger.Log(LogLevel.Error, message: $"Erro tentando enviar email: {e.Message}");
                    throw;
                }

            }


            return View();
        }

        [Route("quem-somos")]
        [Route("sobre-nos")]
        [Route("sobre/{id:guid}/{paciente}/{categoria?}")]
        public IActionResult Sobre(Guid id, string paciente, string categoria)
        {
            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("erro")]
        [Route("erro-encontrado")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("icones")]
        public IActionResult Icones()
        {
            return View();
        }

    }
}
