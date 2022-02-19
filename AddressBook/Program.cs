using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Programs");
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("Enter firstName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter lastName");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter email");
            string email = Console.ReadLine();

            Console.WriteLine("Enter no");
            string no = Console.ReadLine();
            addressBook.addContact(firstName, email, lastName, no);
        }
    }
}
