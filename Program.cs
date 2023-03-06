using System;

namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { firstName = "Shruthi", lastName = "chirra", city = "jagar", state = "warangal", zipcode = "75463", country = "India", phone = "25874963", email = "sunny@gmail.com" });
            people.Add(new Person { firstName = "siri", lastName = "chirra", city = "jagar", state = "warangal", zipcode = "75463", country = "India", phone = "25874963", email = "sunny@gmail.com" });
            people.Add(new Person { firstName = "sunny", lastName = "guntuku", city = "jagar", state = "warangal", zipcode = "75463", country = "India", phone = "25874963", email = "sunny@gmail.com" });


            Person newEntry1 = new Person { firstName = "Shruthi", lastName = "chirra", city = "jagar", state = "warangal", zipcode = "75463", country = "India", phone = "25874963", email = "sunny@gmail.com" };
            if (people.Any(e => e.city == newEntry1.city || e.state == newEntry1.state))
            {
                Console.WriteLine("Contact" + newEntry1.phone);
            }
           

        }
    }
}

