namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EditAddress c1 = new EditAddress();
            String[] names = { "Shruthi", "Sunny", "Pooja", "Dharani" };
            c1.change(names);
        }
    }
    
}

