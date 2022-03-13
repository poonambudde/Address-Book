using System;

namespace AddressBook
{
    interface IContacts
    {
        public void addContact(string firstName, string lastName, string email, string phoneNumber, string address, string zip, string city, String state);
        public void Edit(string Name);
        public void Remove(string name);
    }
}