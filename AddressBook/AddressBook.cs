using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        List<Contact> contacts = new List<Contact>();


        public void addContact(string firstName, string email, string lastName, string no)
        {
            contacts.Add(new Contact()
            {
                firstName = firstName,
                lastName = lastName,
                email = email,
                phoneNumber = phoneNumber,
                address = address,
                zip = zip,        
                city = city,
                state = state,
            });
            Console.WriteLine($"Contact of {firstName} has been added");
        }
    }
}
