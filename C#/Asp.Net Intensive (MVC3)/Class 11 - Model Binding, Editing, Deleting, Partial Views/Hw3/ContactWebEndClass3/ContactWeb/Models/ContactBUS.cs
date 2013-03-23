using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWeb.Models
{
    public class ContactBUS
    {
        const string CACHE_KEY = "ContactCacheKey";

        List<Contact> _db
        {
            get
            {
                var cache = System.Web.HttpContext.Current.Cache;

                List<Contact> data = cache[CACHE_KEY] as List<Contact>;

                if (data == null)
                {
                    data = new List<Contact>();
                    data.Add(new Contact { Id = 1, FirstName = "Eric", LastName = "O?Katz", Email = "ericpkatz@gmail.com" });
                    data.Add(new Contact { Id = 2, FirstName = "Mike", LastName = "Bloomberg", Email = "mbloomberg@gmail.com" });
                    data.Add(new Contact { Id = 5, FirstName = "Andrew", LastName = "Cuomo", Email = "acuomo@gmail.com" });

                    var seed = 0;
                    for (var i = 0; i < 1000; i++)
                    {
                        var rnd = new Random(seed);
                        seed++;
                        var first = (char)('A' + rnd.Next(0, 25));
                        var last = (char)('A' + rnd.Next(0, 25));
                        var email = String.Format("{0}{1}@gmail.com", first, last);
                        var counter = 0;
                        while (data.Any(c => c.Email == email))
                        {
                            counter++;
                            email = String.Format("{0}{1}{2}@gmail.com", first, last, counter);
                        }
                        data.Add(new Contact { FirstName = first.ToString(), LastName = last.ToString(), Email = email, Id = 100 + i });
                    }

                    cache[CACHE_KEY] = data;

                }

                return data;
            }
        }

        public List<Contact> GetContacts()
        {
            return _db;
        }

        public Contact GetContact(int id)
        {
            return _db.Where(c => c.Id == id).SingleOrDefault();
        }

    }
}