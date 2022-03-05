using System;
using System.Collections.Generic;
namespace AddressBook
{
    public class AddressBook
    {
        private List<Contact> _ContactList = new List<Contact>();
        private Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();
        public void AddContact(Contact person)
        {
            _ContactList.Add(person);
        }
        public void GetByEmail(string email)
        {

        }
    }
}