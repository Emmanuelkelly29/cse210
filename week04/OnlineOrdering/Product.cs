class Product
{
    public string Name { get; }
    public string ProductId { get; }
    public double Price { get; }
    public int Quantity { get; }

    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalPrice()
    {
        return Price * Quantity;
    }

    public string GetPackingDetails()
    {
        return $"{Name} (x{Quantity}) - ID: {ProductId}";
    }
}
