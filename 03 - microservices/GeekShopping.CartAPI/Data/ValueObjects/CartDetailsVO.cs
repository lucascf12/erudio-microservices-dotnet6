using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CartAPI.ValueObjects
{
    [Table("cart_details")]
    public class CartDetailsVO
    {
        public long Id { get; set; }

        public long CarteHeaderId { get; set; }

        public CartHeaderVO CartHeader { get; set; }

        public long ProductId { get; set; }

        public int Count { get; set; }
    }
}
