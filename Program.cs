using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Constructors
{
    public class book
    {
        public string tittle;
        public string author;
        public int pages;

        public book(string aTittle, string anAuthor, int aPages)
        {
            tittle = aTittle;
            author = anAuthor;
            pages = aPages;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            book book1 = new book("Its More Than Just Money", "Witness Mdaka", 400);

            Console.WriteLine("Book 1 Author: " + book1.author);

            Console.Read();
        }
        
    }
}
