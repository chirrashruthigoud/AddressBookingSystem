using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class CreateContact
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string Address;
        public string City;
        public int Pincode;
        public int Phone;
        public string State;
        public CreateContact(string fname, string lname, string email, string address, string city, string state, int pincode, int phone)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Email = email;
            this.Address = address;
            this.City = city;
            this.Pincode = pincode;
            this.Phone = phone;
            this.State = state;
            Console.WriteLine("First Name : " + FirstName);
            Console.WriteLine("Last Name : " + LastName);
            Console.WriteLine("Email : " + Email);
            Console.WriteLine("Address : " + Address);
            Console.WriteLine("City Name : " + City);
            Console.WriteLine("Pincode : " + Pincode);
            Console.WriteLine("Phone Number : " + Phone);
            Console.WriteLine("State : " + State);

        }


    }
}