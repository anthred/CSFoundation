using System;
using System.Collections.Generic;

struct Contact
{
    public String Name;
    public String PhoneNumber;
}

class Program
{
    static void Main()
    {
        // TODO: Create a list of Contact
        var contacts = new List<Contact>();

        // TODO: Add contacts to the list
        contacts.Add(new Contact { Name = "Name1", PhoneNumber = "425-000-0000" });
        contacts.Add(new Contact { Name = "Name2", PhoneNumber = "425-000-0001" });

        // TODO: Display the Name and PhoneNumber of all the contacts
        foreach (var contact in contacts)
        {
            Console.WriteLine("{0} {1}", contact.Name, contact.PhoneNumber);
        }

        Console.ReadLine();
    }
}