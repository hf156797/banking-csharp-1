using System;

/// <summary>
/// Represents a customer in the banking system
/// </summary>
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime CreatedDate { get; set; }

    public Customer(int id, string name, string email, string phoneNumber)
    {
        Id = id;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        CreatedDate = DateTime.Now;
    }

    public override string ToString()
    {
        return $"ID: {Id} | Name: {Name} | Email: {Email} | Telefon: {PhoneNumber} | Erstellt: {CreatedDate:dd.MM.yyyy}";
    }
}
