using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSaveMoney.EntityLayer;
using DataLayer.Context;
using DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace DomainLayer.Services {
    public class CategoriaService {
        private readonly CategoriaRepository categoriaRepository;

        public CategoriaService(CategoriaRepository categoriaRepository) {
            this.categoriaRepository = categoriaRepository;
        }
        public void create(Categoria categoria) {
            categoriaRepository.create(categoria);
        }

        public void update(Categoria categoria) {
            categoriaRepository.update(categoria);
        }

        public void delete(int id) {
            categoriaRepository.delete(id);
        }

        public List<Categoria> findAll() {

            return categoriaRepository.findAll();
        }

        public Categoria findById(int id) {
            return categoriaRepository.findById(id);
        }


    }
}
