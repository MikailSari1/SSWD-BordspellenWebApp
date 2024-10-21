namespace Domain;

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    
    public int HouseNumber { get; set; }
    
    public Address(string street, string city, int houseNumber)
    {
        Street = street;
        City = city;
        HouseNumber = houseNumber;
    }
}