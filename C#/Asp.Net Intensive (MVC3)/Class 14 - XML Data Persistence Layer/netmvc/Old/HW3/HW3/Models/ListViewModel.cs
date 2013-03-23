using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWeb.Models
{
    public class ListViewModel
    {
        public List<String> Letters
        {
            get
            {
                return "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z".Split(' ').ToList();
            }
        }

        public Dictionary<string, int> PrefixCount
        {
            get;
            set;
        }

        public List<Contact> Contacts { get; set; }

        public string Prefix { get; set; }

        public bool LetterIsLive(string letter)
        {
            return this.PrefixCount.Keys.Contains(letter);
        }

        public bool LetterIsSelected(string Letter)
        {
            return this.Prefix == Letter;
        }

        public bool Ascending
        {
            get;
            set;
        }
    }
}