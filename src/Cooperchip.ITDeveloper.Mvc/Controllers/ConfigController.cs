using Cooperchip.ITDeveloper.Applications.Extensions;
using Cooperchip.ITDeveloper.Data.ORM;
using Cooperchip.ITDeveloper.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ConfigController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MenuConfig() { return View(); }

        [HttpGet]
        public IActionResult ImportarCid() { return View(); }

        [HttpGet]
        public IActionResult ImportarGenerico() { return View(); }

        public async Task<ActionResult> ImportMedicamentos([FromServices] ITDeveloperDbContext context)
        {
            var filePath = ImportUtils.GetFilePath("Csv", "Medicamentos", ".CSV"); // DELEGUEI

            // Não importa para esta classe como é implementado a leitura e a gravação. - DELEGUEI
            ReadWriteFile rwf = new ReadWriteFile();
            if (!await rwf.ReadAndWriteCsvAsync(filePath, context))
            {
                return View("JaTemMedicamento", context.Medicamento.AsNoTracking().OrderBy(o => o.Codigo));

            }
            else
            {
                return View("ListaMedicamentos", context.Medicamento.AsNoTracking().OrderBy(o => o.Codigo));
            }
        }
    }
}
