using System;

namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { firstName = "Shruthi", lastName = "chirra", city = "jagar", state = "warangal", zipcode = "75463", country = "India", phone = "55455665", email = "shahu@gmail.com" });

            Person newEntry1 = new Person { firstName = "Shruthi", lastName = "chirra", city = "jagar", state = "warangal", zipcode = "75463", country = "India", phone = "55455665", email = "shahu@gmail.com" };
            if (people.Any(e => e.firstName == newEntry1.firstName))
            {
                Console.WriteLine("Duplicate entry: {0}", newEntry1.firstName);
            }
            else
            {
                people.Add(newEntry1);
            }
        }
    }
}

