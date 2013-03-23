using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.IO;
using System.Text;


namespace DAL
{
    public class ContactDAL : BUS.IContactDAL
    {

        public ContactDAL()
        {
            if (!File.Exists(this.GetPath()))
                Populate();
        }


        

         
        private void Populate()
        {
            var doc = new XDocument(
                    new XElement("Contacts")
                );
            var root = doc.Element("Contacts");

            foreach(var contact in new ContactGenerator().Generate())
                root.Add(ToXElement(contact));
            doc.Save(GetPath());

        }

        private BUS.Contact FromXElement(XElement node)
        {
            return new BUS.Contact
            {
                Id = (int)node.Element("Id"),
                FirstName = node.Element("FirstName").Value,
                LastName = node.Element("LastName").Value,
                Email = node.Element("Email").Value,
                LuckyNumber =node.Element("LuckyNumber") != null ? (int)node.Element("LuckyNumber") : (int?)null
            };
        }

        private XElement ToXElement(BUS.Contact contact)
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

        public List<BUS.Contact> GetContacts()
        {
            var doc = GetDocument();

            var results = from contact in doc.Descendants("Contact")
                          select FromXElement(contact);

            return results.ToList();
        }

        public BUS.Contact GetContact(int id)
        {
            var doc = GetDocument();
            var results = doc.Descendants("Contact").Where(contact => (int)contact.Element("Id") == id).Select(contact => FromXElement(contact));
            return results.SingleOrDefault();
        }

        public BUS.Contact GetContact(string email)
        {
            var doc = GetDocument();
            var results = doc.Descendants("Contact").Where(contact => contact.Element("Email").Value.ToLower() == email.ToLower()).Select(contact => FromXElement(contact));
            return results.SingleOrDefault();
        }

        public int Create(BUS.Contact contact)
        {
            var id = GetContacts().Count > 0 ?  this.GetContacts().Max(c => c.Id) + 1 : 1;
            contact.Id = id;
            var doc = this.GetDocument();
            doc.Element("Contacts").Add(ToXElement(contact));
            doc.Save(GetPath());

            return id;
        }

        public void Edit(BUS.Contact contact)
        {
            var doc = GetDocument();
            var nodeToEdit = doc.Descendants("Contact").Where(node => (int)node.Element("Id") == contact.Id).SingleOrDefault();
            nodeToEdit.ReplaceWith(ToXElement(contact));
            doc.Save(GetPath());
        }

        public void Delete(BUS.Contact contact)
        {
            var doc = GetDocument();
            var nodeToDelete = doc.Descendants("Contact").Where(node => (int)node.Element("Id") == contact.Id).SingleOrDefault();
            nodeToDelete.Remove();
            doc.Save(GetPath());
        }



        public IQueryable<BUS.Contact> Contacts
        {
            get { return this.GetContacts().AsQueryable(); }
        }
    }
}