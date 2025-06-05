public class Address
{
    private string _address;
    private string _city;
    private string _stateProvince;

    private string _country;

    public string UsaOrNot()
    {
        if (_country.ToUpper() == "USA")
        {
            return "USA";
        }
        else
        {
            return "Not USA";
        }
    }

    public string AddresDisplayInf()
    {
        return $"Address: {_address}\nCity: {_city}\nState/Province: {_stateProvince}\n{_country}";
    }
}