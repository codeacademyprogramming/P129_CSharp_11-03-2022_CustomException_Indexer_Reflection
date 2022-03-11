using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWork.Models
{
    class Book
    {
        private static int _count;
        public readonly string Code;
        public string Name { get; set; }
        public string AurhoName { get; set; }
        public int PageCount { get; set; }

        public Book(string name, string authorname, int pagecount)
        {
            Name = name;
            AurhoName = authorname;
            PageCount = pagecount;
            _count++;
            Code = $"{Name[0..2].ToUpper()}{_count}";
        }

        public override string ToString()
        {
            return $"Codu: {Code}\nAd: {Name}\nMuellif: {AurhoName}\nSehife Sayi: {PageCount}";
        }
    }
}
