using DevInSales.Core.Entities;

namespace DevInSales.Core.Interface
{
    public interface IProductService
    {
        public void Atualizar();
        public Product ObterProductPorId(int id);
        public bool ProdutoExiste(string nome);
    }

}