using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        // Private member variables.
        private Customer _customer;
        private List<Product> _products;

        // Constructor to initialize the order.
        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        // Adds a product to the order.
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        // Calculates the total cost of the order (products plus shipping).
        public double CalculateTotalCost()
        {
            double total = 0;
            foreach (Product product in _products)
            {
                total += product.GetTotalCost();
            }
            // Shipping cost: $5 for USA, $35 for international.
            double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;
            return total + shippingCost;
        }

        // Returns a packing label listing each product's name and ID.
        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (Product product in _products)
            {
                label += product.GetPackingLabelInfo() + "\n";
            }
            return label;
        }

        // Returns a shipping label with the customer's name and address.
        public string GetShippingLabel()
        {
            return "Shipping Label:\n" + _customer.GetShippingLabel();
        }
    }
}
