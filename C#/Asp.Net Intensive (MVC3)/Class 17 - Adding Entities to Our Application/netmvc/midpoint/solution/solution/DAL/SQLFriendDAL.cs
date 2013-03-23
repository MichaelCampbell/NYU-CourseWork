using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BUS;

namespace DAL
{
    public class SQLFriendDAL : IFriendDAL
    {
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

        public IQueryable<BUS.Friend> Friends
        {
            get { return DB.Friends.Select(dbFriend => new BUS.Friend { ContactID1 = dbFriend.ContactId1, ContactId2 = dbFriend.ContactId2 }); }
        }


        public void Save(ContactWeb.Models.Contact contact, List<BUS.Friend> friends)
        {
            var toDelete = DB.Friends.Where(f => f.ContactId1 == contact.Id || f.ContactId2 == contact.Id);
            DB.Friends.DeleteAllOnSubmit(toDelete);
            foreach(var friend in friends)
            {
                DB.Friends.InsertOnSubmit(new Friend{ContactId1 = friend.ContactID1, ContactId2 = friend.ContactId2});
            }

            DB.SubmitChanges();
        }
    }
}
