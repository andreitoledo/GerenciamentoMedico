using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Cooperchip.ITDeveloper.Mvc.Controllers
{
    public class LoggerController : Controller
    {
        private readonly ILogger<LoggerController> _logger;

        public LoggerController(ILogger<LoggerController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            var usuario = HttpContext.User.Identity.Name;

            _logger.LogTrace($"O usuário: {usuario} foi quem fez isso!");


            try
            {
                throw new Exception("ATENÇÃO: \n UM ERRO(PROPOSITAL) OCORREU. \nCONTATE O ADMINISTRADOR DO SISTEMA!");
            }
            catch (Exception e)
            {

                _logger.LogError($"{e} - Usuário Logado: {usuario}");
            }

            return View();
        }

    }
}
