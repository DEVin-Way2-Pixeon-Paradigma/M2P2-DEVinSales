using DevInSales.Core.Data.Context;
using DevInSales.Core.Entities;
using DevInSales.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DevInSales.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }
        public void Atualizar(Product produtoOriginal, Product produtoAtualizado)
        {
            produtoOriginal.AtualizarDados(produtoAtualizado);
            _context.SaveChanges();
        }

        // obtém o produto por id 
        public Product? ObterProductPorId(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        // verifica se o nome já existe na base de dados
        public bool ProdutoExiste(string nome)
        {
            var produtos = _context.Products.Where(produto => (produto.Name == nome)).ToList();
            return produtos.Count > 0 ? true : false;
        }
        public void Delete(int id)
        {
            var produto = ObterProductPorId(id);
            if (produto == null)
                throw new Exception("o Produto não existe");
            _context.Products.Remove(produto);
            _context.SaveChanges();
        }
    }
}