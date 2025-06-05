using System.Security.Principal;

public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;



    public double ProductTotalCost()
    {
        double totalCost = _price * _quantity;

        return totalCost;
    }
}