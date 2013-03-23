using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWeb.Models
{
    public class ContactDAL
    {
        public List<Contact> GetContacts()
        {
            return new List<Contact>();
        }

        public Contact GetContact(int id)
        {
            return new Contact();
        }

        public Contact GetContact(string email)
        {
            return new Contact();
        }

        public int Create(Contact contact)
        {
            return new int();
        }

        public void Edit(Contact contact)
        {

        }

        public void Delete(Contact contact)
        {

        }
    }
}