using System;
using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public interface IContactDAL
    {
        int Create(Contact contact);
        void Delete(Contact contact);
        void Edit(Contact contact);
        Contact GetContact(int id);
        Contact GetContact(string email);
        IQueryable<Contact> Contacts
        {
            get;
        }
        List<Contact> GetContacts();
    }
}
