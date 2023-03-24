using AddressBookingSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { firstName = "shruthi", lastName = "guntuku", city = "hnk", state = "AP", zipcode = "258741", country = "India", phone = "369852147", email = "JIhu@gmail.com" });
            people.Add(new Person { firstName = "siri", lastName = "guntuku", city = "hnk", state = "AP", zipcode = "258741", country = "India", phone = "369852147", email = "JIhu@gmail.com" });
            people.Add(new Person { firstName = "sunny", lastName = "guntuku", city = "hnk", state = "AP", zipcode = "258741", country = "India", phone = "369852147", email = "JIhu@gmail.com" });


            Person newEntry1 = new Person { firstName = "shruthi", lastName = "guntuku", city = "hnk", state = "AP", zipcode = "258741", country = "India", phone = "369852147", email = "JIhu@gmail.com" };
            if (people.Any(e => e.city == newEntry1.city || e.state == newEntry1.state))
            {
                Console.WriteLine("Multiple Person in same state and same city" + " Name : " + newEntry1.firstName + ", State : " + newEntry1.state + ", City : " + newEntry1.city);
            }
            else
            {
                people.Add(newEntry1);
            }
        }
    }
}