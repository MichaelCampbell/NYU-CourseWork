using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using BUS;

namespace BUS
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^([a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]){1,70}$", ErrorMessage = "Email is not in valid format")]
        public string Email { get; set; }

        [Range(1.0, 100.0)]
        public int? LuckyNumber { get; set; }

        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }

        public string Prefix
        {
            get
            {
                return LastName != null ?  LastName.Substring(0, 1).ToUpper() : String.Empty;
            }
        }

        List<Contact> _friends;

        public List<Contact> Friends
        {
            set { _friends = value; }
            get
            {
                if(_friends == null)
                {
                    var contactLogic = new ContactBUS();
                    var friendLogic = new FriendBUS();
                    var friendsPotential = friendLogic.Friends.Where(f => f.ContactId1 == Id || f.ContactId2 == Id).Select(f => f.ContactId1 == Id ? f.ContactId2 : f.ContactId1);
                    var friends = friendsPotential.ToList();

                    _friends = friends.Select(id => contactLogic.GetContact(id)).ToList();
                }

                return _friends;
            }
        }

    }
}