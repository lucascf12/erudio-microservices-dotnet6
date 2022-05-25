using System.ComponentModel.DataAnnotations.Schema;
using GeekShopping.CartAPI.Model.Base;

namespace GeekShopping.CartAPI.Model
{
    [Table("cart_details")]
    public class CartDetails : BaseEntity
    {
        public long CarteHeaderId { get; set; }

        [ForeignKey("CarteHeaderId")]
        public CartHeader CartHeader { get; set; }

        [ForeignKey("ProducId")]
        public long ProductId { get; set; }

        [Column("count")]
        public int Count { get; set; }
    }
}
