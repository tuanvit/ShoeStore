﻿namespace Shopping.Models
{
    public class CartItemViewModel
    {
        public List<CartItemModel> CartItems { get; set; }

        public decimal GrandTotal { get; set; }
    }
}
