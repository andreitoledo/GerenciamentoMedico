﻿using Cooperchip.ITDeveloper.Data.ORM;
using Cooperchip.ITDeveloper.Mvc.Extensions.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Extensions.ViewComponents.EstadoPaciente
{
    public class EstadoObservacaoViewComponents : ViewComponent
    {
        private readonly ITDeveloperDbContext _context;

        public EstadoObservacaoViewComponents(ITDeveloperDbContext context)
        {
            _context = context;

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var totalGeral = Util.TotReg(_context);
            decimal totalEstado = Util.GetNumRegEstado(_context, estado: "Observação");

            decimal progress = totalEstado * 100 / totalGeral;
            var prct = progress.ToString("F1");

            var model = new ContadorEstadoPaciente()
            {
                Titulo = "Pacientes em Observação",
                Parcial = (int)totalEstado,
                Percentual = prct,
                ClassContainer = "panel panel-default tile panelClose panelRefresh",
                IconeLg = "l-basic-geolocalize-05",
                IconeSm = "fa fa-arrow-circle-o-down s20 mr5 pull-left",
                Progress = progress
            };


            return View(model);
        }

    }
}
