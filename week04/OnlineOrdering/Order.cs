using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalPrice()
    {
        double total = 0;
        foreach (var p in _products)
        {
            total += p.TotalCost();
        }
        total += _customer.IsUSA() ? 5 : 35;
        return total;
    }

    public string PackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var p in _products)
        {
            sb.AppendLine($"{p.Name} (ID: {p.ProductId})");
        }
        return sb.ToString();
    }

    public string ShippingLabel()
    {
        return $"{_customer.Name}\n{_customer.Address.FullAddress()}";
    }
}