using System;

namespace WotAPI
{
    public class ResponseAttribute : Attribute
    {
        public string URLOfRequest;
        public bool ReplaceSearch;

        public ResponseAttribute(string URLOfRequest) : this(URLOfRequest, false) { }

        public ResponseAttribute(string URLOfRequest, bool ReplaceSearch)
        {
            this.URLOfRequest = URLOfRequest;
            this.ReplaceSearch = ReplaceSearch;
        }
    }
}
