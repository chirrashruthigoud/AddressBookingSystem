using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookingSystem
{
    public class CreateContactBuiltArray
    {
        private int numOfContact = Convert.ToInt32(Console.ReadLine());
        private CreateContactBuilt[] CreateContactBuiltsArray;

        public CreateContactBuiltArray()
        {
            this.CreateContactBuiltsArray = new CreateContactBuilt[5];
        }

        public void addContact(string firstName, string lastName, string city, string state, string address, string phone, string postalCode, string email)
        {
            CreateContactBuiltsArray[numOfContact] = new CreateContactBuilt(firstName, lastName, city, state, address, phone, postalCode, email);
            numOfContact++;
        }

        public void run()
        {
            //    for(int i = 0;i< numOfContact;i++)
            //    {
            //        Console.WriteLine(CreateContactBuiltsArray[i]);
            //    }

            foreach (var data in CreateContactBuiltsArray)
            {
                Console.WriteLine(data);
            }
        }
    }
}
