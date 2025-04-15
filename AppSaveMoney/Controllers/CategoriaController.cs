
using AppSaveMoney.EntityLayer;
using DomainLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppSaveMoney.Controllers {
    public class CategoriaController : Controller {        
        private readonly CategoriaService categoriaService;
        public CategoriaController(CategoriaService categoriaService) {
            this.categoriaService = categoriaService;
        }


        public IActionResult Index() {
            var list = categoriaService.findAll();
            return View(list);
        }

        public IActionResult Create() {
            return View();

        }
        [HttpPost, ActionName("Create")]
        public IActionResult Create(Categoria categoria) {
            categoriaService.create(categoria);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id) {
            var categoria = categoriaService.findById(id);
            if (categoria == null)
                return NotFound();

            return View(categoria);
        }

        [HttpPost]
        public IActionResult Edit(int id, Categoria categoria) {
            if (id != categoria.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    categoriaService.update(categoria);
                } catch (DbUpdateConcurrencyException) {
                    if (!CategoriaExists(categoria.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(categoria);
        }

        public IActionResult Delete(int id) {
            var categoria = categoriaService.findById(id);
            if (categoria == null)
                return NotFound();
            return View(categoria);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id) {
            categoriaService.delete(id);
            return RedirectToAction(nameof(Index));
        }


        bool CategoriaExists(int id) {
            return categoriaService.findById(id) == null ? false : true;
        }

    }
}
