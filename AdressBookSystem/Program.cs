namespace AdressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Adress Book System Program !");

            
              //Create contact
              CreateContact.PersonDetails();
            Console.ReadLine();

            //add a new contact
            AddContact.GetCustomer();
            AddContact.ListingPeople();

            // Modify existing contact
            EditContact.GetCustomer();
            EditContact.Modify();
            EditContact.ListingPeople();

        }
    }
}