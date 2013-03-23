using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWeb.Models.LuckyNumber
{
    public class FilterViewModel
    {
        public Dictionary<int, int> LuckyNumberMap { get; set; }
        public int SelectedLuckyNumber { get; set; }
        public List<Contact> Contacts { set; get; }
    }
}