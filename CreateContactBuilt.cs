using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookingSystem
{
    public class CreateContactBuilt
    {
        public string firstName;
        public string lastName;
        public string city;
        public string state;
        public string address;
        public string phone;
        public string postalCode;
        public string email;

        public CreateContactBuilt(string firstName, string lastName, string city, string state, string address, string phone, string postalCode, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            this.state = state;
            this.address = address;
            this.phone = phone;
            this.postalCode = postalCode;
            this.email = email;
        }
    }
}
