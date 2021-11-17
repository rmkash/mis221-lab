using System;
using System.IO;

namespace mis221_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Jeff", 'm', "jlucas@cba.ua.edu");
            Console.WriteLine(myAuthor.ToString());

            Book myBook = new Book("1234","My Book, Your Book",myAuthor);
            Console.WriteLine(myBook.ToString());

            Console.WriteLine("\n"+myBook.GetAuthor().ToString());

            Author yourAuthor = new Author("Jamie",'f',"jamie@mail.com");
            Book yourBook = new Book("4321","The Phantom Book",yourAuthor);
            Console.WriteLine(yourBook.ToString());
            yourAuthor.SetEmail("jdweisberger@crimson.ua.edu");;
            Console.WriteLine(yourBook.ToString());
        }
    }
}
