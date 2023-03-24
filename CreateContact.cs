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
            Console.WriteLine("Enter the index Value to Delete : ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name which you want to delete : ");
            String name = Console.ReadLine();
            if (n[index] == name)
            {
                n[index] = " ";
            }

            Console.Write("After Deleted Array :" + "");

            for (int j = 0; j < n.Length; j++)
            {
                if (n[j] == "")
                {
                    continue;
                }
                else
                {
                    Console.Write(n[j] + " ");
                }
            }

        }
    }
}