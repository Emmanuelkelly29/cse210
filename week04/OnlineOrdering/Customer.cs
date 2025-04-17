class Customer
{
    public string Name { get; }
    public Address Address { get; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public string GetShippingLabel()
    {
        return $"{Name}\n{Address.GetFullAddress()}";
    }

    public bool IsInNigeria()
    {
        return Address.Country.Trim().ToLower() == "nigeria";
    }
}
