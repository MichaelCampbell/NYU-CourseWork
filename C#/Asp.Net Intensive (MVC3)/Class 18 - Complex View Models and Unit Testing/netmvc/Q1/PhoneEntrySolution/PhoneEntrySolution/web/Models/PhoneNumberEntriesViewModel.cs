using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.Models
{
    public class PhoneNumberEntriesViewModel
    {
        private List<PhoneNumberEntry> _entries;

        public List<PhoneNumberEntry> Entries 
        {
            set { _entries = value; }
            get
            {
                if (_entries == null)
                    Entries = new List<PhoneNumberEntry>();
                return _entries;
            }
        }


        public List<PhoneNumberTypes> AllTypes()
        {
            return Enum.GetValues(new PhoneNumberTypes().GetType()).OfType<PhoneNumberTypes>().Select(v=> v).ToList();
        }

        public List<PhoneNumberTypes> UsedTypes()
        {
            return Entries.Select(pe => pe.PhoneNumberType).ToList();
        }

        public List<PhoneNumberTypes> AvailableTypes()
        {
            return AllTypes().Where(pt => !UsedTypes().Contains(pt)).ToList();
        }

        public List<PhoneNumberTypes> AvailableTypes(PhoneNumberEntry entry)
        {
            return AllTypes().Where(pt => !UsedTypes().Contains(pt) || pt == entry.PhoneNumberType).ToList();
        }

        public List<SelectListItem> SelectListItems(PhoneNumberEntry entry)
        {
            return this.AvailableTypes(entry).Select(pt=> new SelectListItem{Text = pt.ToString(), Value = pt.ToString()}).ToList();
        }
    }
}