using DevInSales.Core.Entities;

namespace DevInSales.Core.Interface
{
    public interface IProduct
    {
        public void Atualizar();
        public Product ObterProduct(int id);
    }

}