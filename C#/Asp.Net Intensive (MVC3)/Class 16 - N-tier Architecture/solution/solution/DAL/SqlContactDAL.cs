using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.IO;
using System.Text;
using DAL;
using database = DAL;
using entity = ContactWeb.Models;

namespace ContactWeb.Models
{
    public class SqlContactDAL : BUS.IContactDAL
    {

        public SqlContactDAL()
        {
            if (!DB.Contacts.Any())
                Populate();

        }

        private DAL.ContactWebDBDataContext _db = null;

        private DAL.ContactWebDBDataContext DB
        {
            get
            {
                if (_db == null)
                    _db = new DAL.ContactWebDBDataContext();
                return _db;
            }
        }



        

         
        private void Populate()
        {
            foreach (var contact in new ContactGenerator().Generate())
            {
                
            }

        }

        private entity.Contact FromDatabase(database.Contact contact)
        {
            return new entity.Contact
                       {
                           Id = contact.Id,
                           FirstName = contact.FirstName,
                           LastName = contact.LastName,
                           Email = contact.Email,
                           LuckyNumber = contact.LuckyNumber
                       };
        }

        private database.Contact FromEntity(entity.Contact contact)
        {
            return new database.Contact()
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Email = contact.Email,
                LuckyNumber = contact.LuckyNumber
            };
        }

        private XElement ToXElement(Contact contact)
        {
            var node =  new XElement("Contact",
                        new XElement("Id", contact.Id),
                        new XElement("FirstName", contact.FirstName),
                        new XElement("LastName", contact.LastName),
                        new XElement("Email", contact.Email)
                );

            if (contact.LuckyNumber.HasValue)
                node.Add(new XElement("LuckyNumber", contact.LuckyNumber.Value));

            return node;
        }

        private string GetPath()
        {
            return System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Contacts.xml");
        }

        private XDocument GetDocument()
        {
            return XDocument.Load(GetPath());
        }

        public List<Contact> GetContacts()
        {
            var results = from contact in DB.Contacts
                          select FromDatabase(contact);
                                     //{
                                     //    Id = contact.Id,
                                     //    FirstName = contact.FirstName,
                                     //    LastName = contact.LastName,
                                     //    LuckyNumber = contact.LuckyNumber,
                                     //    Email = contact.Email
                                     //};
            //var doc = GetDocument();

            //var results = from contact in doc.Descendants("Contact")
            //              select FromXElement(contact);

            return results.ToList();
        }

        public Contact GetContact(int id)
        {
            var results = from contact in DB.Contacts
                          where contact.Id == id
                          select FromDatabase(contact);

                                     //{
                                     //    Id = contact.Id,
                                     //    FirstName = contact.FirstName,
                                     //    LastName = contact.LastName,
                                     //    LuckyNumber = contact.LuckyNumber,
                                     //    Email = contact.Email
                                     //};
            //var doc = GetDocument();
            //var results = doc.Descendants("Contact").Where(contact => (int)contact.Element("Id") == id).Select(contact => FromXElement(contact));
            return results.SingleOrDefault();
        }

        public Contact GetContact(string email)
        {
            var results = from contact in DB.Contacts
                          where contact.Email.ToLower() == email.ToLower()
                          select FromDatabase(contact);
            //var doc = GetDocument();
            //var results = doc.Descendants("Contact").Where(contact => contact.Element("Email").Value.ToLower() == email.ToLower()).Select(contact => FromXElement(contact));
            return results.SingleOrDefault();
        }

        public int Create(Contact contact)
        {
            var dbContact = FromEntity(contact);
            DB.Contacts.InsertOnSubmit(dbContact);
            DB.SubmitChanges();

            //var id = GetContacts().Count > 0 ?  this.GetContacts().Max(c => c.Id) + 1 : 1;
            //contact.Id = id;
            //var doc = this.GetDocument();
            //doc.Element("Contacts").Add(ToXElement(contact));
            //doc.Save(GetPath());

            return dbContact.Id;
        }

        public void Edit(Contact contact)
        {
            //var toEdit = GetContact(contact.Id);
            var toEdit = DB.Contacts.Where(c => c.Id == contact.Id).SingleOrDefault();
            toEdit.FirstName = contact.FirstName;
            toEdit.LastName = contact.LastName;
            toEdit.Email = contact.Email;
            toEdit.LuckyNumber = contact.LuckyNumber;
            DB.SubmitChanges();
            //var doc = GetDocument();
            //var nodeToEdit = doc.Descendants("Contact").Where(node => (int)node.Element("Id") == contact.Id).SingleOrDefault();
            //nodeToEdit.ReplaceWith(ToXElement(contact));
            //doc.Save(GetPath());
        }

        public void Delete(Contact contact)
        {
            var toDelete = DB.Contacts.Where(c => c.Id == contact.Id);
            DB.Contacts.DeleteOnSubmit(toDelete.SingleOrDefault());
            DB.SubmitChanges();
            //var doc = GetDocument();
            //var nodeToDelete = doc.Descendants("Contact").Where(node => (int)node.Element("Id") == contact.Id).SingleOrDefault();
            //nodeToDelete.Remove();
            //doc.Save(GetPath());
        }

    }
}