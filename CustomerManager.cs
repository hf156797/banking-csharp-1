using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Manages customer operations
/// </summary>
public class CustomerManager
{
    private List<Customer> customers = new List<Customer>();
    private int nextId = 1;

    /// <summary>
    /// Add a new customer
    /// </summary>
    public void AddCustomer(string name, string email, string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Fehler: Name darf nicht leer sein!");
            return;
        }

        Customer newCustomer = new Customer(nextId++, name, email, phoneNumber);
        customers.Add(newCustomer);
        Console.WriteLine($"✓ Kunde '{name}' erfolgreich hinzugefügt (ID: {newCustomer.Id})");
    }

    /// <summary>
    /// Display all customers
    /// </summary>
    public void DisplayAllCustomers()
    {
        if (customers.Count == 0)
        {
            Console.WriteLine("\n⚠ Keine Kunden vorhanden.");
            return;
        }

        Console.WriteLine("\n" + new string('=', 80));
        Console.WriteLine("KUNDENLISTE");
        Console.WriteLine(new string('=', 80));
        
        foreach (var customer in customers)
        {
            Console.WriteLine(customer);
        }
        
        Console.WriteLine(new string('=', 80));
        Console.WriteLine($"Gesamt: {customers.Count} Kunde(n)\n");
    }

    /// <summary>
    /// Remove a customer by ID
    /// </summary>
    public void RemoveCustomerById(int id)
    {
        Customer customer = customers.FirstOrDefault(c => c.Id == id);
        
        if (customer == null)
        {
            Console.WriteLine($"Fehler: Kunde mit ID {id} nicht gefunden!");
            return;
        }

        customers.Remove(customer);
        Console.WriteLine($"✓ Kunde '{customer.Name}' (ID: {id}) erfolgreich gelöscht.");
    }

    /// <summary>
    /// Get customer by ID
    /// </summary>
    public Customer GetCustomerById(int id)
    {
        return customers.FirstOrDefault(c => c.Id == id);
    }

    /// <summary>
    /// Get total customer count
    /// </summary>
    public int GetCustomerCount()
    {
        return customers.Count;
    }
}
