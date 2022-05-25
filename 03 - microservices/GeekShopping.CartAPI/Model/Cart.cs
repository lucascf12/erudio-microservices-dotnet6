using System.Collections.Generic;

namespace GeekShopping.CartAPI.Model
{
    public class Cart
    {
        public CartHeaders CartHeaders { get; set; }
        public IEnumerable<CartDetails> CartDetails { get; set; }

    }
}
