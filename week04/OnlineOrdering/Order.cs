public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customers;

    public void SetProduct(List<Product> product)
    {
        _products = product;
    }

    public void SetCustomer(Customer customer)
    {
        _customers = customer;
        
    }


    public double OrderTotalPrice()
    {
        int usaShipping = 5;
        int nonUsaShipping = 35;
        double total =  0; 

            foreach(var product in _products)
        {
            total += product.ProductTotalCost();
        }


        if (_customers.LiveInUsa())
        {
            total += usaShipping;

        }
        else
        {
            total += nonUsaShipping;
        }

        return total;
    }

    public string PackingLabel()
    {
        string productNameAndId = " ";
        foreach (var product in _products)
        {
            productNameAndId += "Product Name: " + product.GetName() + "\tProduct ID " + product.GetProductId() + "\n";
        }

        return productNameAndId;
    }

    public string ShippingLabel()
    {
        return "Customer Name: " + _customers.GetCustomerName() + "\nCustomer Address: " + _customers.FullAddress();
    }

}