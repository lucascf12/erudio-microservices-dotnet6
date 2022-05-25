﻿using System.Collections.Generic;

namespace GeekShopping.CartAPI.ValueObjects
{
    public class CartVO
    {
        public CartHeaderVO CartHeader { get; set; }
        public IEnumerable<CartDetailsVO> CartDetails { get; set; }

    }
}
