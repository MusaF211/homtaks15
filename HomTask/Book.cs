using System;
using System.Collections.Generic;
using System.Text;

namespace HomTask
{
    class Book
    {
        private static int _count;
        private string v1;
        private string v2;
        private int v3;
        public readonly string Code;
        public string AuthorName { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }


        public Book(string code, string authorname, string name, int pagecount)
        {
            Name = name;
            Code = code;
            AuthorName = authorname;
            PageCount = pagecount;
            _count++;
            Code = $"{Name[0..2].ToUpper()}{_count}";
     
        }

        public Book(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public override string ToString()
        {
            return $"Code: {Code}\nAuthor: {AuthorName}\nName: {Name}\nPageCount: {PageCount}";
        }
    }
}
