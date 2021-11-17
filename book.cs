using System;

namespace oop_lab_rmkash
{
    public class Author
    {
        //instance variables
        private string isbn;
        private string title;
        private Author author;
        public Book(string tempIsbn, string tempTitle, Author tempAuthor)
        {
            isbn = tempIsbn;
            title = tempTitle;
            author=tempAuthor;
        }
        public string GetIsbn()
        {
            return isbn;
        }
        public void SetIsbn(string tempIsbn)
        {
            isbn = tempIsbn;
        }
        public string GetTitle()
        {
            return isbn;
        }
        public void SetTitle(string tempTitle)
        {
            title = tempTitle;
        }
        public string GetAuthor()
        {
            return author;
        }
        public void SetAuthor(Author tempAuthor)
        {
            author = tempAuthor;
        }
        public override string ToString()
        {
            string message;
            //if there is a TV available, tell the user the size, manufacturer, and price
            if (message) 
            {
                message = "A ";
            }
            else
            {
                message = "You bought ";
            }
            //return the message
            return message;
        }
    }
}