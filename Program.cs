using System;

namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { firstName = "Shruthi", lastName = "chirra", city = "jagar", state = "warangal", zipcode = "75463", country = "India", phone = "55455665", email = "shahu@gmail.com" });
            people.Add(new Person { firstName = "Shruthi", lastName = "chirra", city = "jagar", state = "warangal", zipcode = "75463", country = "India", phone = "5545556", email = "shu@gmail.com" });
            people.Add(new Person { firstName = "sunny", lastName = "guntuku", city = "jagar", state = "warangal", zipcode = "75463", country = "India", phone = "55455665", email = "shahu@gmail.com" });


            Person newEntry1 = new Person { firstName = "Sagar", lastName = "Shahu", city = "jagar", state = "warangal", zipcode = "75463", country = "India", phone = "55455665", email = "shahu@gmail.com" };
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

