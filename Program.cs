namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DeleteContacts c1 = new DeleteContacts();
            String[] names = { "Shruthi", "Sunny", "Chinnu", "Siri" };
            c1.change(names);
        }
    }
}

