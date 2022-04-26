using System.ComponentModel.DataAnnotations;

namespace DevInSales.Core.Entities
{
    public class Product : Entity
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatorio")]
        public string Name { get; private set; }
        
        [Required(ErrorMessage = "O Campo {0} é obrigatorio")]
        public decimal SuggestedPrice { get; private set; }

        public Product(string name, decimal suggestedPrice)
        {
            Name = name;
            SuggestedPrice = suggestedPrice;
        }
    }
}