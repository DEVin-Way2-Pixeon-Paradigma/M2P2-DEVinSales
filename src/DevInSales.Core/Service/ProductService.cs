using DevInSales.Core.Data.Context;
using DevInSales.Core.Entities;
using DevInSales.Core.Interface;


namespace DevInSales.Core.Service
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context) {
            _context = context;
        }
        public void Atualizar()
        {
            _context.SaveChanges();
        }

        public Product ObterProductPorId(int id)
        {
            return _context.Products.Find(id);
        }

        // verifica se o nome já existe na base de dados
        public bool ProdutoExiste(string nome)
        {
            var produtos  = _context.Products.Where(produto => (produto.Name == nome)).ToList();
            return produtos.Count > 0 ? true:false;
        }
    }
}