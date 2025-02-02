namespace OnlineOrdering
{
    public class Address
    {
        // Private member variables.
        private string _street;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        // Constructor to initialize the address.
        public Address(string street, string city, string stateOrProvince, string country)
        {
            _street = street;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }

        // Returns true if the address is in the USA.
        public bool IsInUSA()
        {
            return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES" || _country.ToUpper() == "US";
        }

        // Returns a formatted full address.
        public string GetFullAddress()
        {
            return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
        }
    }
}
