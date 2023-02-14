namespace AdressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Adress Book System Program !");

            // add a new contact
            CreateContact.PersonDetails();
            Console.ReadLine();
        }
    }
}