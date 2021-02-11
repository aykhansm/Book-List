using System;
using System.Collections.Generic;
using System.Text;

namespace _11022021
{
    class Book
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 3)
                    _name = value;
            }
        }
        private int _pagecount;
        public int PageCount
        {
            get
            {
                return _pagecount;
            }
            set
            {
                if (value >= 10)
                    _pagecount = value;
            }
        }
        public Book(string name,int pagecount)
        {
            this.Name = name;
            this.PageCount = pagecount;
        }
    }
}
