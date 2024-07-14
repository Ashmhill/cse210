// Order.cs
using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double TotalCost()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }

        if (customer.IsInUSA())
        {
            total += 5; // Shipping cost for USA
        }
        else
        {
            total += 35; // Shipping cost for non-USA
        }

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (var product in products)
        {
            packingLabel.AppendLine($"{product.Name} (ID: {product.ProductId})");
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{customer.Name}\n{customer.Address}";
    }
}
