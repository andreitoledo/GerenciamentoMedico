using Cooperchip.ITDeveloper.Data.ORM;
using Cooperchip.ITDeveloper.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Controllers
{
    [Authorize]
    public class GenericoController : Controller
    {
        // injeta o contexto do projeto DATA
        private readonly ITDeveloperDbContext _context;

        public GenericoController(ITDeveloperDbContext context)
        {
            _context = context;
        }

        //[Route("lista-de-genericos")]
        // traz a lista de todos os genericos, ordena por codigo, chama o metodo tolistasync() e manda para a view
        [HttpGet]
        public async Task<IActionResult> Index()
        {            
            var listGenerico = await _context.Generico.AsNoTracking()
                .OrderBy(o => o.Codigo)
                .ToListAsync();
            return View(listGenerico);
        }

        //[Route("detalhe-de-generico/{id:guid}")]
        // no detalhes, passa o guid e verifica se é nulo, compara o id generico com o parametro.
        [HttpGet]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id.Value == null)
            {
                return NotFound();
            }

            var generico = await _context.Generico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generico == null)
            {
                return NotFound();
            }

            return View(generico);
        }

        //[Route("adicionar-generico")]        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //[Route("adicionar-generico")]
        // na lista, ao clicar em algum link traz para o create, monta a tela com os campos, rotulos e os filds para preencher
        // tem um botão para submite form, chama o cliente post e chega no metodo create que verifica se o modelo é valido e grava.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Generico generico)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //generico.Id = Guid.NewGuid();
                    _context.Add(generico);
                    await _context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(generico);
        }

        //[Route("editar-generico/{id:guid}")]
        // esse edit é quando clica em uma linha qualquer, abre o dado ja cadastrado, altera e grava.
        [HttpGet]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generico = await _context.Generico.FindAsync(id);
            if (generico == null)
            {
                return NotFound();
            }
            return View(generico);
        }


        //[Route("editar-generico/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Generico generico)
        {
            if (id != generico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(generico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenericoExists(generico.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(generico);
        }

        //[Route("excluir-generico/{id:guid}")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generico = await _context.Generico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generico == null)
            {
                return NotFound();
            }

            return View(generico);
        }

        //[Route("excluir-generico/{id:guid}"), ActionName("Delete")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var generico = await _context.Generico.FindAsync(id);
            _context.Generico.Remove(generico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // verifica se existe algum registro nesse genérico
        private bool GenericoExists(Guid id)
        {
            return _context.Generico.Any(e => e.Id == id);
        }
    }
}
