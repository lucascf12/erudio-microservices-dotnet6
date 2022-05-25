using System.ComponentModel.DataAnnotations.Schema;
using GeekShopping.CartAPI.Model.Base;

namespace GeekShopping.CartAPI.Model
{
    [Table("cart_header")]
    public class CartHeader : BaseEntity
    {
        [Column("use_id")]
        public string UserId { get; set; }

        [Column("cupon_code")]
        public string CuponCode { get; set; }
    }
}
