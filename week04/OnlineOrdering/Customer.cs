public class Customer
{       
    private string _name;
    private Address _address = new Address();

    public Customer()
    {

    }
    public Customer(string customerName, string street, string city, string stateProvince, string country)
    {
        _name = customerName;
        _address.SetStreetAddress(street);
        _address.SetCity(city);
        _address.SetStateProvince(stateProvince);
        _address.SetCountry(country);
    }

    public string GetCustomerName()
    {
        return _name;
    }
    public string FullAddress()
    {
        return _address.FullAddressInf();
    }
    public bool LiveInUsa()
    {
        return _address.IsInUsa();
    }
}