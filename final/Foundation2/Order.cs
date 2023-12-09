public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public string PackingLabel()
    {
        string label = "Products:\n";
        foreach (var product in _products)
        {
            label += $"{product.Name} (Product ID: {product.ProductId})\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"{_customer.Name}\n{_customer.Address.ToString()}";
    }

    public double TotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.Price * product.Quantity;
        }
        return total;
    }
}