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
            CreateContact c1 = new CreateContact();
            String[] names = { "shruthi", "chinnu", "sunny", "pooja" };
            c1.change(names);
        }
    }
}