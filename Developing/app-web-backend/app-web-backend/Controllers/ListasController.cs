using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app_web_backend.Models;

namespace app_web_backend.Controllers
{
    public class ListasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ListasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Listas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Listas.Include(l => l.Anime).Include(l => l.Usuario);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Listas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lista = await _context.Listas
                .Include(l => l.Anime)
                .Include(l => l.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lista == null)
            {
                return NotFound();
            }

            return View(lista);
        }

        // GET: Listas/Create
        public IActionResult Create()
        {
            ViewData["AnimeId"] = new SelectList(_context.Animes, "Id", "Descricao");
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }

        // POST: Listas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UsuarioId,AnimeId,Avaliacao")] Lista lista)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lista);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AnimeId"] = new SelectList(_context.Animes, "Id", "Descricao", lista.AnimeId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", lista.UsuarioId);
            return View(lista);
        }

        // GET: Listas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lista = await _context.Listas.FindAsync(id);
            if (lista == null)
            {
                return NotFound();
            }
            ViewData["AnimeId"] = new SelectList(_context.Animes, "Id", "Descricao", lista.AnimeId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", lista.UsuarioId);
            return View(lista);
        }

        // POST: Listas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UsuarioId,AnimeId,Avaliacao")] Lista lista)
        {
            if (id != lista.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lista);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListaExists(lista.Id))
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
            ViewData["AnimeId"] = new SelectList(_context.Animes, "Id", "Descricao", lista.AnimeId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", lista.UsuarioId);
            return View(lista);
        }

        // GET: Listas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lista = await _context.Listas
                .Include(l => l.Anime)
                .Include(l => l.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lista == null)
            {
                return NotFound();
            }

            return View(lista);
        }

        // POST: Listas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lista = await _context.Listas.FindAsync(id);
            _context.Listas.Remove(lista);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListaExists(int id)
        {
            return _context.Listas.Any(e => e.Id == id);
        }
    }
}
