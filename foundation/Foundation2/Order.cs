public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double TotalCost()
    {
        double sum = _products.Sum(p => p.TotalCost());
        if (_customer.LivesInUSA())
        {
            return sum + 5;
        }
        return sum + 35;
    }

    public string PackingLabel()
    {
        return string.Join("\n", _products.Select(p => p.PackingLabel()));
    }

    public string ShippingLabel()
    {
        return _customer.ShippingLabel();
    }
}