// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.

using System;
using System.Globalization;

struct ItemData
{
    public string ItemId;
    public string Description;
    public double PricePerItem;
    public int QuantityOnHand;
    public double OurCostPerItem;
    public double ValueOfItem;
}

enum MessageType
{
    Success=1,
    Info=2,
    Warning=3,
    Error=4
}

class Program
{
    public static void Main()
    {
        int countOfItems = 0;
        const int minItems = 10; // must have atleast these many items in the inventory
        var items = new ItemData[100];

        string strx;
        int optx;

        while (true)
        {
            Console.WriteLine("M A I N   M E N U");
            Console.WriteLine("==================");
            Console.WriteLine("1) Add Item");
            Console.WriteLine("2) Change Item");
            Console.WriteLine("3) Delete Item");
            Console.WriteLine("4) List Items");
            Console.WriteLine("5) Quit");

            Console.Write("Enter your choice: ");
            strx = Console.ReadLine();
            optx = int.Parse(strx);
            Console.WriteLine();

            switch (optx)
            {
                case 1: // add an item to the list if this option is selected
                    {
                        AddItems(items, ref countOfItems);
                        break;
                    }

                case 2: // change items in the list if this option is selected
                    {
                        if (countOfItems > 0)
                        {
                            Console.Write("Please enter the Item Id to change: ");
                            string changeItemId = Console.ReadLine();

                            ChangeItem(items, changeItemId, countOfItems);
                        }
                        else
                        {
                            WriteMessage("No items found.");
                        }

                        break;
                    }

                case 3: // delete items in the list if this option is selected
                    {
                        if (countOfItems > 0)
                        {
                            if (countOfItems <= minItems)
                            {
                                WriteMessage(string.Format("Cannot delete due to low inventory - only {0} item(s) left.", countOfItems.ToString()), MessageType.Warning);
                            }
                            else
                            {
                                Console.Write("Please enter the Item Id to delete: ");
                                string deleteItemId = Console.ReadLine();

                                DeleteItem(items, deleteItemId, ref countOfItems);
                            }
                        }
                        else
                        {
                            WriteMessage("No items found.");
                        }

                        break;
                    }

                case 4:  // list all items in current database if this option is selected
                    {
                        if (countOfItems > 0)
                        {
                            ListItems(items, countOfItems);
                        }
                        else
                        {
                            WriteMessage("No items found.");
                        }

                        break;
                    }

                case 5: //quit the program if this option is selected
                    {
                        Console.Write("Are you sure that you want to quit(y/n)? ");
                        string input = Console.ReadLine();

                        if (input.ToUpper().Equals("Y"))
                        {
                            //optx = 0; //as long as it is not 5, the process is not breaking
                            strx = "QUIT";
                        }

                        break;
                    }

                default:
                    {
                        Console.Clear();
                        //Console.Write("Invalid Option, try again");

                        break;
                    }
            }

            // quit menu
            //if (optx == 0)
            if (strx.ToUpper() == "QUIT")
                break;

            Console.WriteLine();
        }
    }

    public static void AddItems(ItemData[] items, ref int countOfItems)
    {
        Console.Write("ItemId: ");
        var itemId = Console.ReadLine();

        // check if it exists already
        if (countOfItems >= 0 && FindItem(items, itemId, countOfItems) < 0)
        {
            items[countOfItems].ItemId = itemId;

            Console.Write("Description: ");
            var itemDesc = Console.ReadLine();
            items[countOfItems].Description = itemDesc;

            Console.Write("PricePerItem: ");
            var pricePerItem = double.Parse(Console.ReadLine());
            items[countOfItems].PricePerItem = pricePerItem;

            Console.Write("QuantityOnHand: ");
            var qtyonHand = int.Parse(Console.ReadLine());
            items[countOfItems].QuantityOnHand = qtyonHand;

            Console.Write("OurCostPerItem: ");
            var ourCostPerItem = double.Parse(Console.ReadLine());
            items[countOfItems].OurCostPerItem = ourCostPerItem;

            // Auto update ValueOfItem (price * quantity on hand)
            items[countOfItems++].ValueOfItem = pricePerItem * qtyonHand;

            WriteMessage(string.Format("Item {0} added successfully", itemId), MessageType.Success);
        }
        else
        {
            WriteMessage(string.Format("Item {0} already exists", itemId), MessageType.Warning);
        }
    }

    public static void ChangeItem(ItemData[] items, string itemId, int countOfItems)
    {
        int itemIndexToUpdate = FindItem(items, itemId, countOfItems);

        if (itemIndexToUpdate >= 0)
        {
            // update item
            string strx;
            int optx;

            while (true)
            {
                Console.WriteLine("Change Item Menu");
                Console.WriteLine("================");
                Console.WriteLine("1) Change Description");
                Console.WriteLine("2) Change PricePerItem");
                Console.WriteLine("3) Change QuantityOnHand");
                Console.WriteLine("4) Change OurCostPerItem");
                Console.WriteLine("5) Quit");

                Console.Write("Enter your choice: ");
                strx = Console.ReadLine();
                optx = int.Parse(strx);
                Console.WriteLine();

                switch (optx)
                {
                    case 1: // Description
                        {
                            Console.Write("Enter Description: ");
                            var itemDesc = Console.ReadLine();
                            items[itemIndexToUpdate].Description = itemDesc;

                            break;
                        }

                    case 2: // PricePerItem
                        {
                            Console.Write("PricePerItem: ");
                            var pricePerItem = double.Parse(Console.ReadLine());
                            items[itemIndexToUpdate].PricePerItem = pricePerItem;

                            // Auto update ValueOfItem (price * quantity on hand)
                            items[itemIndexToUpdate].ValueOfItem = pricePerItem * items[itemIndexToUpdate].QuantityOnHand;

                            break;
                        }

                    case 3: // QuantityOnHand
                        {
                            Console.Write("QuantityOnHand: ");
                            var qtyonHand = int.Parse(Console.ReadLine());
                            items[itemIndexToUpdate].QuantityOnHand = qtyonHand;

                            // Auto update ValueOfItem (price * quantity on hand)
                            items[itemIndexToUpdate].ValueOfItem = items[itemIndexToUpdate].PricePerItem * qtyonHand;

                            break;
                        }

                    case 4: // OurCostPerItem
                        {
                            Console.Write("OurCostPerItem: ");
                            var ourCostPerItem = double.Parse(Console.ReadLine());
                            items[itemIndexToUpdate].OurCostPerItem = ourCostPerItem;

                            break;
                        }

                    case 5:
                        {
                            Console.Write("Are you sure that you want to quit(y/n)? ");
                            string input = Console.ReadLine();

                            if (input.ToUpper().Equals("Y"))
                            {
                                //optx = 0; //as long as it is not 5, the process is not breaking
                                strx = "QUIT";
                            }

                            break;
                        }

                    default:
                        {
                            WriteMessage("Invalid Option, try again", MessageType.Error);
                            break;
                        }
                }

                if (strx.ToUpper() == "QUIT")
                    break;

                Console.WriteLine();
            }

            WriteMessage(string.Format("Item {0} updated successfully", itemId), MessageType.Success);
        }
        else
        {
            WriteMessage(string.Format("Item {0} not found", itemId), MessageType.Warning);
        }
    }

    public static void DeleteItem(ItemData[] items, string itemId, ref int countOfItems)
    {
        int itemIndexToDelete = FindItem(items, itemId, countOfItems);

        if (itemIndexToDelete >= 0)
        {
            // delete item
            for (var index = itemIndexToDelete; index < countOfItems; index++)
            {
                items[index] = items[index + 1];
            }

            // reduce the overall item count
            countOfItems--;

            WriteMessage(string.Format("Item {0} deleted successfully", itemId), MessageType.Success);
        }
        else
        {
            WriteMessage(string.Format("Item {0} not found", itemId), MessageType.Warning);
        }
    }

    public static void ListItems(ItemData[] items, int countOfItems)
    {
        if (countOfItems == 0)
        {
            WriteMessage("No items available");
        }
        else
        {
            string sym = CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;

            Console.WriteLine("Item#  ItemID  Description           Price    QOH   Cost     Value");
            Console.WriteLine("-----  ------  --------------------  -------  ----  -------  ----------");
            for (int i = 0; i < countOfItems; i++)
            {
                Console.WriteLine("{0,5}  {1,6}  {2,-20}  {3}  {4,4}  {5}  {6}",
                    i + 1,
                    items[i].ItemId,
                    items[i].Description,
                    string.Format("{0}{1,6:#,##0.00}", sym, items[i].PricePerItem),
                    items[i].QuantityOnHand,
                    string.Format("{0}{1,6:#,##0.00}", sym, items[i].OurCostPerItem),
                    string.Format("{0}{1,9:#,##0.00}", sym, items[i].ValueOfItem)
                    );
            }
        }
    }

    public static int FindItem(ItemData[] items, string itemId, int countOfItems)
    {
        int itemIndex = -1;

        for (int i = 0; i < countOfItems; i++)
        {
            if (items[i].ItemId == itemId)
            {
                itemIndex = i;
                break;
            }
        }

        return itemIndex;
    }

    public static void WriteMessage(string message, MessageType type = MessageType.Info)
    {
        switch (type)
        {
            case MessageType.Success: 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                }

            case MessageType.Info:
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                }

            case MessageType.Warning:
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                }

            case MessageType.Error:
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                }
        }
        
        Console.WriteLine(message);
        Console.ResetColor();
    }
}