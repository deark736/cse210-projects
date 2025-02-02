namespace OnlineOrdering
{
    public class Customer
    {
        // Private member variables.
        private string _name;
        private Address _address;

        // Constructor to initialize the customer.
        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        // Returns true if the customer lives in the USA.
        public bool LivesInUSA()
        {
            return _address.IsInUSA();
        }

        // Returns a shipping label string for the customer.
        public string GetShippingLabel()
        {
            return $"{_name}\n{_address.GetFullAddress()}";
        }
    }
}
