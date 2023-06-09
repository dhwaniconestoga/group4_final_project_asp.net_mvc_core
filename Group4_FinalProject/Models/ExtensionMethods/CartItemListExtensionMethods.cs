﻿using System.Linq;
using System.Collections.Generic;

namespace Group4_FinalProject.Models
{
    public static class CartItemListExtensions
    {
        public static List<CartItemDTO> ToDTO(this List<CartItem> list) =>
            list.Select(ci => new CartItemDTO {
                ProductId = ci.Product.ProductId,
                Quantity = ci.Quantity
            }).ToList();
    }
}
