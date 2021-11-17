using System;
using System.IO;

namespace mis221_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("jeff", 'm', "jlucas@cba.ua.edu");
            Console.WriteLine(myAuthor.ToString());

            Book myBook = new Book("1234","my book, your book",myAuthor);
            Console.WriteLine(myBook.ToString());

            Book yourBook = new Book("4321","The Phantom Book",new Author("Jamie",'f',"jamie@gmail.com"));
        }
    }
}
