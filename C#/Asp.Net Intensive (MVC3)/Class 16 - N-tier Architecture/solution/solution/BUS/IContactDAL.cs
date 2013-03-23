using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContactWeb.Models;

namespace BUS
{
// ReSharper disable InconsistentNaming
    public interface IContactDAL
// ReSharper restore InconsistentNaming
    {
        List<Contact> GetContacts();
        Contact GetContact(int id);
        Contact GetContact(string email);
        int Create(Contact contact);
        void Edit(Contact contact);
        void Delete(Contact contact);
    }
}
