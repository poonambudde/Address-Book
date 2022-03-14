using System;

namespace AddressBook
{
    interface IContacts
    {
        public void addContact(string firstName, string lastName, string email, string phoneNumber, string address, string zip, string city, string state);
        public void Edit(string firstName);
        public void delete(string name);
        public void displayContact();
    }
}