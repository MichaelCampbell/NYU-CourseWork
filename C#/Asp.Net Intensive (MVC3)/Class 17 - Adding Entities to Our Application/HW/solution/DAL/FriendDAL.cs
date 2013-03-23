using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.IO;
using System.Text;

namespace DAL
{
    class FriendDAL : BUS.IFriendDAL
    {

        public FriendDAL()
        {
            if (!File.Exists(this.GetPath()))
            {
                Populate();
            }
        }

        private void Populate()
        {
            var doc = new XDocument(new XElement("Friends"));
            var root = doc.Element("Friends");

            //foreach(var contact in new ContactGenerator().Generate())
            //root.Add(ToXElement(contact));
            //doc.Save(GetPath());
        }

        private Friend FromXElement(XElement node)
        {
            return new Friend
            {
                ContactId1 = (int)node.Element("ContactId1"),
                ContactId2 = (int)node.Element("ContactId2")
            };
        }

        private XElement ToXElement(Friend friend)
        {
            var node =  new XElement("Friends",
                        new XElement("ContactId1", friend.ContactId1),
                        new XElement("ContactId2", friend.ContactId2)
                );
            return node;
        }

        private string GetPath()
        {
            return System.Web.HttpContext.Current.Server.MapPath("~/App-Data/Friends.xml");
        }

        private XDocument GetDocument()
        {
            return XDocument.Load(GetPath());
        }

        public List<Friend> GetFriends(Contact contact)
        {
            var doc = GetDocument();

            var results = from friend in doc.Descendants("Friend")
                          select FromXElement(friend);

            return results.ToList();
        }
        public Friend GetFriend(int id)
        {
            var doc = GetDocument();
            var results = doc.Descendants("Friends").Where(contact => (int)contact.Element("ContactId1") == id || (int)contact.Element("ContactId2") == id).Select(friend => FromXElement(friend));

            return results.SingleOrDefault();
        }

        public IQueryable<BUS.Friend> Friends
        {
            get { throw new NotImplementedException(); }
        }

        public void Save(ContactWeb.Models.Contact contact, List<BUS.Friend> friends)
        {
            throw new NotImplementedException();
        }
    }
}
