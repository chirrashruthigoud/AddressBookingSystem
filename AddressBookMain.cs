using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookingSystem
{
    public class AddressBookMain
    {
        public static List<Contact> add = new List<Contact>();
        public static void AddContact()
        {
            string choice;
            Console.WriteLine("\n Do you want to add new Contact ? (Y/N):");
            choice = Console.ReadLine();
            while (choice == "y" || choice == "Y")
            {
                Contact contacts = new Contact();
                Console.WriteLine("Enter First Name");
                contacts.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                contacts.LastName = Console.ReadLine();
                Console.WriteLine("Enter Address ");
                contacts.Address = Console.ReadLine();
                Console.WriteLine("Enter City");
                contacts.City = Console.ReadLine();
                Console.WriteLine("Enter State Name");
                contacts.State = Console.ReadLine();
                Console.WriteLine("Enter Zip Code ");
                contacts.ZipCode = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter Phone Number ");
                contacts.Phonenumber = long.Parse(Console.ReadLine());
                add.Add(contacts);

            }
        }

        public static void Display()
        {
            foreach (Contact data in add)
            {
                Console.WriteLine("FirstName:" + data.FirstName);
                Console.WriteLine("LastName:" + data.LastName);
                Console.WriteLine("Address:" + data.Address);
                Console.WriteLine("City:" + data.City);
                Console.WriteLine("State:" + data.State);
                Console.WriteLine("Zip Code:" + data.ZipCode);
                Console.WriteLine("PhoneNumber:" + data.Phonenumber);

            }
        }



        public static void DeleteContact(string personName)
        {
            for (int i = 0; i < add.Count; i++)
            {
                if (add[i].FirstName == personName)
                {
                    Console.WriteLine("Record {0} successfully deleted", add[i].FirstName);
                    add.RemoveAt(i);
                }
            }
        }

        public static void AddMultipleConatcts()
        {
            Console.WriteLine("Enter the Number of Record you want to insert");
            int number = (int)Convert.ToInt64(Console.ReadLine());
            while (number > 0)
            {
                AddContact();
                number--;
            }
        }
    }
}
