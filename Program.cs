﻿using AddressBookingSystem;
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

            Person newEntry1 = new Person { firstName = "shruthi", lastName = "guntuku", city = "Nagpur", state = "TS", zipcode = "854712", country = "India", phone = "55455665", email = "mkihu@gmail.com" };
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