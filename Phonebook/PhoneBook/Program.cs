using System;
using System.Collections.Generic;

public class Program
{
    static List<Contact> contactList = new();

    struct Contact
    {
        public string Name;
        public int Number;
        public string Email;
    }

    public static void Main()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select an option: ");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. View All Contacts");
            Console.WriteLine("3. Search for a Contact");
            Console.WriteLine("4. Delete a Contact");
            Console.WriteLine("5. Quit (or type 'q')");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "1")
            {
                Console.WriteLine();
                Contact newContact = new();
                Console.WriteLine("Contact Name:");
                newContact.Name = Console.ReadLine();

                Console.WriteLine("Contact Number:");
                string contactNumberInput = Console.ReadLine();
                if (int.TryParse(contactNumberInput, out int parsedNumber))
                {
                    newContact.Number = parsedNumber;
                }
                else
                {
                    Console.WriteLine("Invalid number entered. Setting number to 0.");
                    newContact.Number = 0;
                }

                Console.WriteLine("Contact Email:");
                newContact.Email = Console.ReadLine();
                contactList.Add(newContact);

                Console.WriteLine("\nData retrieved successfully!");
                Console.WriteLine($"Name: {newContact.Name}");
                Console.WriteLine($"Number: {newContact.Number}");
                Console.WriteLine($"Email: {newContact.Email}\n");
            }

            else if (userInput == "2")
            {
                if (contactList.Count == 0)
                {
                    Console.WriteLine("No contacts to display.");
                }
                else
                {
                    Console.WriteLine("\nContact List:");
                    Console.WriteLine("-------------\n");

                    foreach (Contact contact in contactList)
                    {
                        Console.WriteLine($"Name: {contact.Name}");
                        Console.WriteLine($"Number: {contact.Number}");
                        Console.WriteLine($"Email: {contact.Email}");
                        Console.WriteLine("--------------------------");
                    }
                }
            }

            else if (userInput == "3")
            {
                Console.WriteLine("Enter a name to search for:");
                string searchName = Console.ReadLine().Trim();
                bool contactFound = false;

                foreach (Contact contact in contactList)
                {
                    if (contact.Name.ToLower().Contains(searchName.ToLower()))
                    {
                        Console.WriteLine($"Name: {contact.Name}");
                        Console.WriteLine($"Number: {contact.Number}");
                        Console.WriteLine($"Email: {contact.Email}");
                        Console.WriteLine("--------------------------");
                        contactFound = true;
                    }
                }

                if (!contactFound)
                {
                    Console.WriteLine("No contacts found matching that name.\n");
                }
            }

            else if (userInput == "4")
            {
                if (contactList.Count == 0)
                {
                    Console.WriteLine("No contacts to delete.");
                    continue;
                }

                for (int i = 0; i < contactList.Count; i++)
                {
                    Console.WriteLine($"{i}: {contactList[i].Name}");
                }

                Console.WriteLine("Enter the number of the contact to delete:");
                string contactIndexInput = Console.ReadLine();

                if (int.TryParse(contactIndexInput, out int contactIndexToDelete))
                {
                    if (contactIndexToDelete >= 0 && contactIndexToDelete < contactList.Count)
                    {
                        Contact contactToDelete = contactList[contactIndexToDelete];

                        Console.WriteLine($"\nYou selected:");
                        Console.WriteLine($"Name: {contactToDelete.Name}");
                        Console.WriteLine($"Number: {contactToDelete.Number}");
                        Console.WriteLine($"Email: {contactToDelete.Email}");
                        Console.WriteLine("Are you sure you want to delete this contact? (y/n)");

                        string confirm = Console.ReadLine().ToLower();
                        if (confirm == "y")
                        {
                            contactList.RemoveAt(contactIndexToDelete);
                            Console.WriteLine("Contact deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Deletion cancelled.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid contact number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            else if (userInput == "5" || userInput == "quit" || userInput == "q")
            {
                Console.WriteLine("See you next time!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please select a valid number (1–5).");
            }
        }
    }
}
