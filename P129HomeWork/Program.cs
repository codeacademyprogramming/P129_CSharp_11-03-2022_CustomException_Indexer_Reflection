using P129HomeWork.Models;
using System;

namespace P129HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.Books.Add(new Book("CSharp", "Andres Helsber", 500));
            library.Books.Add(new Book("Sefiller", "Viktor Hugo", 300));
            library.Books.Add(new Book("Iskendername", "Nizami Gencevi", 650));
            library.Books.Add(new Book("Xemse", "Nizami Gencevi", 200));
            library.Books.Add(new Book("CSharp", "Andres Helsber", 500));

            library.RemoveAllBookByName("Iskendername");

            foreach (var item in library.SearchBooks("Niz"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
