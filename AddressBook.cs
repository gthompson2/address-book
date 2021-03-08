using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        public List<Contact> Contacts { get; set; }

        public AddressBook()
        {
            Contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public Contact GetByEmail(string email)
        {
            foreach (Contact contact in Contacts)
            {
                if (contact.Email == email)
                {
                    return contact;
                }
            }
            return null;
        }
    }
}