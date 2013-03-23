using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWeb.Models.LuckyNumber
{
    public class FilterViewModel
    {
        public Dictionary<int, int> LuckyNumberMap
        {
            set;
            get;
        }

        public int SelectedLuckyNumber { set; get; }

        public List<Contact> Contacts { set; get; }

    }
}