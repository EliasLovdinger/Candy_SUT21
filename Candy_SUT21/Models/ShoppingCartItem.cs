using System.ComponentModel.DataAnnotations;

namespace Candy_SUT21.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartItemsId { get; set; }
        public string ShoppingCartId { get; set; }
        public Candy Candy { get; set; }
        public int Amount { get; set; }

    }
}
