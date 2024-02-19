public class Order {
    private List<Product> _products;
    private Customer _customer;

    public Order (Customer customer, List<Product> products) {
        _customer = customer;
        _products = products;
    }

    public float totalCost() {
        float sum = 0;
        foreach (Product product in _products) {
            sum += product.productFinalCost();
        }
        if (_customer.GetAddress().UsaAddress()) {
            sum += 5;
        }
        else {
            sum += 35;
        }
        return sum;
    }
    public void PackingLabel () {
        foreach (Product product in _products) {
            Console.Write($"Id: {product.GetProductId()} --- ");
            Console.WriteLine($"Name: {product.GetName()}");
        }
        
    }
    public void ShippingLabel () {
        Console.WriteLine($"Customer: {_customer.GetName()}");
        Console.WriteLine($"Address: {_customer.GetAddress().FullAddress()}");
    }

}