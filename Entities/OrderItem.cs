using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TreiningForCompositionAndEnums.Entities
{
    class OrderItem
    {
        public int QuantityOrder { get; set; }
        public double PriceOrder { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantityOrder, double priceOrder, Product product)
        {
            QuantityOrder = quantityOrder;
            PriceOrder = priceOrder;
            Product = product;
        }

        public double SubTotal()
        {
            return QuantityOrder * PriceOrder;
        }

        public override string ToString()
        {
            return Product.NameProduct
                + ", $"
                + PriceOrder.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + QuantityOrder
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
