using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.Mvc;

namespace web.Models
{
    public class PhoneNumberEntriesViewModel
    {
        private List<PhoneNumberEntry> _entries; 
        public List<PhoneNumberEntry> Entries
        {
            get
            {
                if(_entries == null)
                {
                    Entries = new List<PhoneNumberEntry>();
                }
                return _entries;
            }
            set { _entries = value; }
        }

        public List<PhoneNumberTypes> AllTypes()
        {
            return null;
        }

        /// <summary>
        /// Types currently being used
        /// </summary>
        /// <returns>List<PhoneNumberTypes></returns>
        public List<PhoneNumberTypes> UsedTypes()
        {
            return null;
        }

        public List<PhoneNumberTypes> AvailableTypes()
        {
            return null;
        }

        public List<PhoneNumberTypes> AvailableTypes(PhoneNumberEntry entry)
        {
            return null;
        }

        public List<SelectListItems> SelectListItemses(PhoneNumberEntry, entry)
        {
            return null;
        }
}