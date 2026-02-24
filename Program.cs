using System;

class Program
{
    static void Main()
    {
        CustomerManager manager = new CustomerManager();
        
        // Beispiel-Kunden hinzufügen
        manager.AddCustomer("Max Mustermann", "max@example.com", "0170-123456");
        manager.AddCustomer("Anna Schmidt", "anna@example.com", "0171-654321");
        manager.AddCustomer("Peter Mueller", "peter@example.com", "0172-789012");

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n╔════════════════════════════════════════╗");
            Console.WriteLine("║     BANKING KUNDENVERWALTUNG          ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.WriteLine("1. Kunde hinzufügen");
            Console.WriteLine("2. Alle Kunden anzeigen");
            Console.WriteLine("3. Kunde löschen");
            Console.WriteLine("4. Beenden");
            Console.Write("\nWählen Sie eine Option (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNewCustomer(manager);
                    break;
                case "2":
                    manager.DisplayAllCustomers();
                    break;
                case "3":
                    DeleteCustomer(manager);
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("\nAuf Wiedersehen!");
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe. Bitte eine Nummer von 1-4 eingeben.");
                    break;
            }
        }
    }

    /// <summary>
    /// Prompts user to add a new customer
    /// </summary>
    static void AddNewCustomer(CustomerManager manager)
    {
        Console.WriteLine("\n--- Neuen Kunde hinzufügen ---");
        
        Console.Write("Name: ");
        string name = Console.ReadLine();
        
        Console.Write("Email: ");
        string email = Console.ReadLine();
        
        Console.Write("Telefonnummer: ");
        string phone = Console.ReadLine();

        manager.AddCustomer(name, email, phone);
    }

    /// <summary>
    /// Prompts user to delete a customer
    /// </summary>
    static void DeleteCustomer(CustomerManager manager)
    {
        if (manager.GetCustomerCount() == 0)
        {
            Console.WriteLine("\n⚠ Keine Kunden zum Löschen vorhanden.");
            return;
        }

        manager.DisplayAllCustomers();

        Console.Write("Geben Sie die ID des zu löschenden Kunden ein: ");
        
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            manager.RemoveCustomerById(id);
        }
        else
        {
            Console.WriteLine("Fehler: Ungültige ID");
        }
    }
}
