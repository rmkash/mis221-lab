using System;

namespace mis221_lab
{
    public class Book
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
        public Author GetAuthor()
        {
            return author;
        }
        public void SetAuthor(Author tempAuthor)
        {
            author = tempAuthor;
        }
        public override string ToString()
        {
            string message = "\nISBN = "+isbn+",   Title = "+title+",   Author: "+author;
            return message;
        }
    }
}