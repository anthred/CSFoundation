﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
struct Item
{
    public int PetId;
    public string Name;
}

class Inventory
{
    Item[] items;
    int itemCount;

    public Inventory()
    {
        items = new Item[10];
    }

    private string FileName = "inventory.dat";

    private BinaryFormatter formatter = new BinaryFormatter();

    public void LoadFile()
    {
        // TODO: Check if the file exists (File.Exists)
        if (File.Exists(FileName))
        {
            // TODO: Open the file (File.Open)
            FileStream stream = File.Open(FileName, FileMode.Open);

            // TODO: Deserialize the stream using (Item[])
            items = (Item[])formatter.Deserialize(stream);

            // TODO: Close the stream
            stream.Close();
        }
    }

    public void SaveFile()
    {
        // TODO: Recreate the file (File.Create)
        FileStream stream = File.Create(FileName);

        // TODO: Serialize the items
        formatter.Serialize(stream, items);

        // TODO: Close the stream
        stream.Close();
    }

    public void Add(int petId, string name)
    {
        Item item;

        item.PetId = petId;
        item.Name = name;

        items[itemCount] = item;

        itemCount++;
    }

    public void ListAll()
    {
        Console.WriteLine("List All Pets");
        for (int index = 0; index < itemCount; index++)
        {
            Item item = items[index];

            Console.WriteLine(
            "{0,4} {1}",
            item.PetId,
            item.Name);
        }
    }
}

class ProjectMain
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        inventory.Add(1, "Rover");
        inventory.Add(2, "Chippie");
        inventory.SaveFile();

        inventory.LoadFile();

        inventory.ListAll();

        Console.ReadLine();

    } // Main()
} // class ProjectMain