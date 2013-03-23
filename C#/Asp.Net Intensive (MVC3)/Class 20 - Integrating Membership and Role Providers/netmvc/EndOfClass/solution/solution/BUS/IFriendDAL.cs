using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public interface IFriendDAL
    {
        IQueryable<Friend> Friends
        {
            get;
        }

        void Save(Contact contact, List<Friend> friends);
    }
}
