public class Customer
{
    private string _name;
    Address address;

    public string LiveInUSA()
    {
        string response = address.UsaOrNot();

        return response;
    }
}