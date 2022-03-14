﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Contact
    {
        public Contact(string firstName, string lastName, string email, string phoneNumber, string address, string zip, string city, string state)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.zip = zip;
            this.city = city;
            this.state = state;
        }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public string phoneNumber { get; set; }

        public string address { get; set; }

        public string zip { get; set; }

        public string city { get; set; }

        public string state { get; set; }
    }
}
