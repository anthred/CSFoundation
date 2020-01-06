using System;

class Contact
{
    public string FirstName = "";
    public string LastName = "";
    public int Age = 0;

    public string GetFullName()
    {
        return String.Format("{0} {1}", this.FirstName, this.LastName);
    }
}

class Program
{
    static void Main()
    {
        Contact contact = new Contact();

        contact.FirstName = "Anthony";
        contact.LastName = "Badri";
        contact.Age = 23;

        // GetFullName() returns "FirstName LastName"
        Console.WriteLine("Name: {0} Age: {1}", contact.GetFullName(), contact.Age);
    }
}