using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace ContactWeb.Models
{
    public class ContactBUS
    {
        //const string CACHE_KEY = "GetContacts";

        //private Random random = new Random((int)DateTime.Now.Ticks);//thanks to McAden

        /*
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 *random.NextDouble() + 65)));
                builder.Append(i == 0 ? ch : char.ToLower(ch));
            }

            return builder.ToString();
        }*/


        /*
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
                        string email = String.Format("{0}_{1}@gmail.com", firstName, lastName);

                        var counter = 0;
                        while (contacts.Count(c => c.Email == email) > 0)
                        {
                            counter++;
                            email = String.Format("{0}_{1}{2}@gmail.com", firstName, lastName, counter);
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
        }*/

        private ContactDAL DAL;

        public ContactBUS()
        {
            DAL = new ContactDAL();
        }

        public List<Contact> GetContacts()
        {
            return DAL.GetContacts();
        }

        public Contact GetContact(int id)
        {
            return DAL.GetContact(id);
        }

        public Contact GetContact(string email)
        {
            if (email == null)
                return null;

            return DAL.GetContact(email);
        }

        public void Delete(Contact contact)
        {
            DAL.Delete(contact);
        }

        public int Create(Contact contact)
        {
            return DAL.Create(contact);
        }

        public void Edit(Contact contact)
        {
            DAL.Edit(contact);
        }

    }
}