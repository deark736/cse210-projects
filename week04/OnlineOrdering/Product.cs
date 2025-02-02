namespace OnlineOrdering
{
    public class Product
    {
        // Private member variables.
        private string _name;
        private string _productId;
        private double _pricePerUnit;
        private int _quantity;

        // Constructor to initialize the product.
        public Product(string name, string productId, double pricePerUnit, int quantity)
        {
            _name = name;
            _productId = productId;
            _pricePerUnit = pricePerUnit;
            _quantity = quantity;
        }

        // Returns the total cost of the product.
        public double GetTotalCost()
        {
            return _pricePerUnit * _quantity;
        }

        // Returns product info for the packing label.
        public string GetPackingLabelInfo()
        {
            return $"{_name} (ID: {_productId})";
        }
    }
}
