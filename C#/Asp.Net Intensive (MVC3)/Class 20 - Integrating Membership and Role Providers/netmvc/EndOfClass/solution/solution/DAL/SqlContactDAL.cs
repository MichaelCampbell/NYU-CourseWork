using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.IO;
using System.Text;
using database = DAL;
using entity = BUS;


namespace DAL
{
    public class SqlContactDAL : BUS.IContactDAL
    {

        public SqlContactDAL()
        {
            if (DB.Contacts.Count() == 0)
                Populate();


        }

        private DAL.ContactWebDBDataContext _db = null;

        private DAL.ContactWebDBDataContext DB
        {
            get
            {
                if (_db == null)
                    _db =
                        new DAL.ContactWebDBDataContext(
                            System.Configuration.ConfigurationManager.ConnectionStrings["ContactWebDB"].ConnectionString);
                return _db;
            }
        }
         
        private void Populate()
        {
                    foreach (var contact in new ContactGenerator().Generate(10000))
                        Create(contact);

        }

        private entity.Contact FromDataBase(database.Contact contact)
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
            return new database.Contact
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Email = contact.Email,
                LuckyNumber = contact.LuckyNumber
            };
        }

        private Contact FromXElement(XElement node)
        {
            return new Contact
            {
                Id = (int)node.Element("Id"),
                FirstName = node.Element("FirstName").Value,
                LastName = node.Element("LastName").Value,
                Email = node.Element("Email").Value,
                LuckyNumber =node.Element("LuckyNumber") != null ? (int)node.Element("LuckyNumber") : (int?)null
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

        public List<BUS.Contact> GetContacts()
        {
            var results = from contact in DB.Contacts
                          select FromDataBase(contact);

            return results.ToList();
        }

        public BUS.Contact GetContact(int id)
        {
            var results = from contact in DB.Contacts
                          where contact.Id == id
                          select FromDataBase(contact);
            return results.SingleOrDefault();
        }

        public BUS.Contact GetContact(string email)
        {
            var results = from contact in DB.Contacts
                          where contact.Email.ToLower() == email.ToLower()
                          select FromDataBase(contact);
            return results.SingleOrDefault();
        }

        public int Create(BUS.Contact contact)
        {
            var dbContact = FromEntity(contact);
            DB.Contacts.InsertOnSubmit(dbContact);
            DB.SubmitChanges();
            return dbContact.Id;
        }

        public void Edit(BUS.Contact contact)
        {
            //database.Contact toEdit = GetContact(contact.Id);
            database.Contact toEdit = DB.Contacts.Where(c => c.Id == contact.Id).SingleOrDefault();
            toEdit.FirstName = contact.FirstName;
            toEdit.LastName = contact.LastName;
            toEdit.Email = contact.Email;
            toEdit.LuckyNumber = contact.LuckyNumber;
            DB.SubmitChanges();
        }

        public void Delete(BUS.Contact contact)
        {
            var toDelete = DB.Contacts.Where(c => c.Id == contact.Id);
            DB.Contacts.DeleteOnSubmit(toDelete.SingleOrDefault());
            DB.SubmitChanges();
        }



        public IQueryable<BUS.Contact> Contacts
        {
            get { return DB.Contacts.Select(c => new BUS.Contact{Id = c.Id, Email = c.Email, FirstName = c.FirstName, LastName = c.LastName, LuckyNumber = c.LuckyNumber}); }
        }
    }
}