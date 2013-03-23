using System;
using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public interface IContactDAL
    {
        int Create(ContactWeb.Models.Contact contact);
        void Delete(ContactWeb.Models.Contact contact);
        void Edit(ContactWeb.Models.Contact contact);
        ContactWeb.Models.Contact GetContact(int id);
        ContactWeb.Models.Contact GetContact(string email);
        IQueryable<ContactWeb.Models.Contact> Contacts
        {
            get;
        }
        System.Collections.Generic.List<ContactWeb.Models.Contact> GetContacts();
    }
}
