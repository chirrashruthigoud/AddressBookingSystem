namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Program ");

            Console.WriteLine("Add Personal Details : firstname, lastname, email, address, city, state, pincode, phone");
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            string Email = Console.ReadLine();
            string Address = Console.ReadLine();
            string City = Console.ReadLine();
            string State = Console.ReadLine();
            string Pincode = Console.ReadLine();
            string Phone = Console.ReadLine();

            AddAddress c1 = new AddAddress(FirstName, LastName, Email, Address, City, State, Pincode, Phone);

        }
    }
    
}

