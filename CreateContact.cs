using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class CreateContact
    {

        public String name;
        public void change(String[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
            Console.Write("If You Want to Edit Array Type Index Value : ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Name : ");
            String name = Console.ReadLine();
            n[index] = name;
            Console.Write(n[index] = name);

            for (int j = 0; j < n.Length; j++)
            {
                Console.WriteLine("Updated Array : " + n[j]);
            }

        }
    }
}