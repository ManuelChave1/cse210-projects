public class Address
{       
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public void SetStreetAddress(string street)
    {
        _streetAddress = street;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public void SetStateProvince(string stateProvince)
    {
        _stateProvince = stateProvince;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public bool IsInUsa()
    {
        if (_country.ToUpper() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string FullAddressInf()
    {
        return $"Address: {_streetAddress}\nCity: {_city}\nState/Province: {_stateProvince}\nCountry: {_country}";
    }
}