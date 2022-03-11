using System;
using System.Collections.Generic;
using System.Text;

namespace P129HomeWork.Models
{
    class Library
    {
        public List<Book> Books;

        public Library()
        {
            Books = new List<Book>();
        }

        public List<Book> FindAllBooksByName(string val)
        {
            //List<Book> books = Books.FindAll(b=>b.Name.ToLower().Contains(val.ToLower().Trim()));
            //return books;
            return Books.FindAll(b => b.Name.ToLower().Contains(val.ToLower().Trim()));
        }

        public void RemoveAllBookByName(string val)
        {
            Books.RemoveAll(b => b.Name.ToLower().Contains(val.ToLower().Trim()));
        }

        public List<Book> SearchBooks(string search)
        {
            return Books.FindAll(b => b.Name.ToLower().Contains(search.ToLower().Trim()) ||
            b.AurhoName.ToLower().Contains(search.ToLower().Trim()) ||
            b.PageCount.ToString().Contains(search.ToLower().Trim()));
        }

        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            return Books.FindAll(b => b.PageCount >= min && b.PageCount <= max);
        }

        public void RemoveByNo(string code)
        {
            Book book = Books.Find(b => b.Code.ToLower() == code.ToLower().Trim());

            if (book != null)
            {
                Books.Remove(book);
                return;
            }

            Console.WriteLine("Daxil Edilen Code-da Kitab Tapilmadi");

            //if (Books.Exists(b => b.Code.ToLower() == code.ToLower().Trim()))
            //{
            //    Books.Remove(Books.Find(b => b.Code.ToLower() == code.ToLower().Trim()));
            //    return;
            //}
            //Console.WriteLine("Daxil Edilen Code-da Kitab Tapilmadi");
        }
    }
}
