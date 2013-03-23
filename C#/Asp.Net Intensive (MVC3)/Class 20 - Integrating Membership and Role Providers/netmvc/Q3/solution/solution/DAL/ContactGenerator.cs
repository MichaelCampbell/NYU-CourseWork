using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DAL
{
    public class ContactGenerator
    {
        private Random random = new Random((int)DateTime.Now.Ticks);//thanks to McAden

        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(i == 0 ? ch : char.ToLower(ch));
            }

            return builder.ToString();
        }

        public List<Contact> Generate()
        {
            return Generate(500);
        }
        public List<Contact> Generate(int max)
        {
            var contacts = new List<Contact>();
            for (var i = 1; i <= max; i++)
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
            return contacts;
        }
    }
}
