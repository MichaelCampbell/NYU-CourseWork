using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    class ContactGenerator
    {
        private Random random = new Random((int)DateTime.Now.Ticks);//thanks to McAden

        public List<ContactWeb.> 

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
        }

                    //var doc = new XDocument(
            //        new XElement("Contacts")
            //    );
            //var root = doc.Element("Contacts");
            var contacts = new List<ContactWeb.Models.Contact>();
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
                            new ContactWeb.Models.Contact
                            {
                                FirstName = firstName,
                                LastName = lastName,
                                Id = i,
                                Email = email
                            }
                        );
                    }

                    foreach (var contact in contacts)
                        Create(contact);
                //root.Add(ToXElement(contact));
            //doc.Save(GetPath());
    }

}
