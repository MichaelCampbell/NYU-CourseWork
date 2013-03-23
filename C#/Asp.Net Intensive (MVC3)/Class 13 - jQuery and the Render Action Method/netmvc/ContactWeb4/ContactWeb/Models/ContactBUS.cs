using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace ContactWeb.Models
{
    public class ContactBUS
    {
        const string CACHE_KEY = "GetContacts";

        private Random random = new Random((int)DateTime.Now.Ticks);//thanks to McAden


        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 *random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }


        List<Contact> _data
        {
            get
            {
                var cache = System.Web.HttpContext.Current.Cache;

                List<Contact> contacts = cache[CACHE_KEY] as List<Contact>;
                if (contacts == null)
                {
                    contacts = new List<Contact>();
                    for (var i = 1; i <= 500; i++)
                    {
                        var firstName = RandomString(4);
                        var lastName = RandomString(6);
                        string email = String.Format("{0}{1}@gmail.com", firstName, lastName);

                        var counter = 0;
                        while (contacts.Count(c => c.Email == email) > 0)
                        {
                            counter++;
                            email = String.Format("{0}{1}{2}@gmail.com", firstName, lastName, counter);
                        }

                        contacts.Add(
                            new Contact
                            {
                                FirstName = firstName,
                                LastName = lastName,
                                Id = i,
                                Email = email
                            }
                        );
                    }

                }
                cache[CACHE_KEY] = contacts;
                return contacts;
            }
        }

        public List<Contact> GetContacts()
        {
            return _data;
        }

        public Contact GetContact(int id)
        {
            return _data.Where(c => c.Id == id).SingleOrDefault();
        }

        public void Delete(Contact contact)
        {
            var _contact = this.GetContact(contact.Id);
            _data.Remove(_contact);
        }

        public int Create(Contact contact)
        {
            contact.Id = _data.Max(c => c.Id) + 1;
            _data.Add(contact);
            return contact.Id;
        }

        public void Edit(Contact contact)
        {
            var toEdit = GetContact(contact.Id);
            toEdit.FirstName = contact.FirstName;
            toEdit.LastName = contact.LastName;
            toEdit.Email = contact.Email;
        }

    }
}