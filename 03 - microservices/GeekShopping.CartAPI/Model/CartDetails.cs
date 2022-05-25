using System.ComponentModel.DataAnnotations.Schema;
using GeekShopping.CartAPI.Model.Base;

namespace GeekShopping.CartAPI.Model
{
    [Table("cart_details")]
    public class CartDetails : BaseEntity
    {
        public long CartHeaderId { get; set; }

        [ForeignKey("CartHeaderId")]
        public virtual CartHeaders CartHeaders { get; set; }

        public long ProductId { get; set; }

        [ForeignKey("ProducId")]
        public virtual Product Product { get; set; }



        [Column("count")]
        public int Count { get; set; }
    }
}
