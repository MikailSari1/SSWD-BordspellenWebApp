namespace Domain;

public class User
{
    public string Name { get; set; }
    
    public string Email { get; set; }

    public Gender Gender;
    
    public Address Address { get; set; }

    public User(string name, string email, Gender gender, Address address)
    {
        Name = name;
        Email = email;
        Gender = gender;
        Address = address;
    }
}