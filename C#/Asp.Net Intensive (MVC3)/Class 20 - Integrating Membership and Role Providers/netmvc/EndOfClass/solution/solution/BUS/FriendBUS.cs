using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BUS
{
    public class FriendBUS
    {
        IFriendDAL DAL;

        public FriendBUS()
        {
            var settings = System.Configuration.ConfigurationManager.AppSettings["FriendDAL"].Split(',');
            DAL = System.Reflection.Assembly.Load(settings[1]).CreateInstance(settings[0]) as IFriendDAL;
        }

        public IQueryable<Friend> Friends
        {
            get
            {
                return DAL.Friends;
            }
        }

        public void  Save(Contact contact, List<Friend> friends){
            //friends = friends.Where(friend => friend.ContactId1 == friend.ContactId2 && friend.ContactId2 == contact.Id).ToList();
            DAL.Save(contact, friends);
        }

    }
}
