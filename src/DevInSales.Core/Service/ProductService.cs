using DevInSales.Core.Data.Context;
using DevInSales.Core.Entities;
using DevInSales.Core.Interface;


namespace DevInSales.Core.Service
{
    public class ProductService : IProduct
    {
        private readonly DataContext _context;

        public ProductService(DataContext context) {
            _context = context;
        }
        public void Atualizar()
        {
            _context.SaveChanges();
        }

        public Product ObterProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}