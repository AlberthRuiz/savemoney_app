using DataLayer.Context;
using AppSaveMoney.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository {
    public class CategoriaRepository {
        private readonly ApplicationDbContext _context;

        public CategoriaRepository(ApplicationDbContext context) {
            this._context = context;
        }

        public void create(Categoria categoria) {
            _context.Add(categoria);
            _context.SaveChanges();
        }

        public void update(Categoria categoria) {
            _context.Update(categoria);
            _context.SaveChanges();
        }

        public void delete(int id) {
            var categoria = _context.Categorias.FirstOrDefault(c => c.Id == id);
            if (categoria != null) {
                _context.Remove(categoria);
                _context.SaveChanges();
            }
        }

        public List<Categoria> findAll() {
            var lst = _context.Categorias.ToList();
            return lst;
        }

        public Categoria findById(int id) {
            return _context.Categorias.FirstOrDefault(x => x.Id == id);
        }


    }
}
