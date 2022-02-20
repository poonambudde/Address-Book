﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        List<Contact> contacts = new List<Contact>();


        public void addContact(string firstName, string email, string lastName, string phoneNumber, string address, string city, string zip ,string state)
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

        public void Edit(string name)
        {
            contacts.Find(x => x.firstName == name);
            Contact editContact = null;
            foreach (var contact in contacts)
            {
                if (contact.firstName.Contains(name))
                {
                    editContact = contact;
                }
            }

            Console.WriteLine("Plz provide new firstName");
            editContact.firstName = Console.ReadLine();
            Console.WriteLine("Plz provide new lastName");
            editContact.lastName = Console.ReadLine();
            Console.WriteLine("Plz provide new email");
            editContact.email = Console.ReadLine();
            Console.WriteLine("Plz provide new phoneNumber");
            editContact.phoneNumber = Console.ReadLine();
            Console.WriteLine("Plz provide new address");
            editContact.address = Console.ReadLine();
            Console.WriteLine("Plz provide new zip");
            editContact.zip = Console.ReadLine();
            Console.WriteLine("Plz provide new city");
            editContact.city = Console.ReadLine();
            Console.WriteLine("Plz provide new state");
            editContact.state = Console.ReadLine();
           
            contacts.Add(editContact);
            Console.WriteLine($"Contact of {name} has been edited");
        }
    }
}
