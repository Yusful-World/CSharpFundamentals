using System;
using System.Collections.Generic;

namespace MoshInt_Indexers
{
    public class HttpCookie
    {
        private Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        public DateTime ExpiryDate { get; set; }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
