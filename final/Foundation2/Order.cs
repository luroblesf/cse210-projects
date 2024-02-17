using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer) 
    {
        _products = products;
        _customer = customer;
    }

    public float CalculateShipping() 
    {
        float shippingCost = _customer.usaCustomer() ? 5 : 35;
        return shippingCost;
    }

    public float CalculateTotalPrice()
    {
        float totalprice = 0;

        foreach (Product p in _products) 
        {
            float price = p.CalculatePrice();
            totalprice += price;
        }

        float shippingCost = CalculateShipping();
        totalprice += shippingCost;
        return totalprice;
    }

    public string PackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product p in _products) 
        {
            packingLabel += p.GetnameProduct() + " - " + p.GetidProduct() + "\n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += _customer.GetName() + "\n" + _customer.GenerateAddress();
        return shippingLabel;
    }

    public string GetTotalCost()
    {
        string totalCost = "\nProducts:\n";
        float totalPrice = CalculateTotalPrice();

        foreach (Product p in _products) 
        {
            totalCost += p.GetName() + " (" + p.GetProductID() + ") - " + "$" + p.GetPrice() + " x " + p.GetQuantity() + " = " + p.CalculatePrice() + "\n";
        }
        
        totalCost += "Shipping Cost: $" + CalculateShipping() + "\n";
        totalCost += "Total: $" + CalculateTotalPrice();
        
        return totalCost;
    }

    public void DisplayResults()
    {
        string packingLabel = PackingLabel();
        string shippingLabel = ShippingLabel();
        string totalCost = GetTotalCost();

        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine(totalCost);
    }
}