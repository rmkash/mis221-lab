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
            if (isAvailable==true) 
            {
                message = "A "+SCREEN_SIZE+" inch "+MANUFACTURER+" TV is available for purchase for $"+price;
            }
            //if there isnt a TV available, tell the user what they bought, price per payment, and the amount of payments
            else
            {
                message = "You bought a "+SCREEN_SIZE+" inch "+MANUFACTURER+" TV. You'll pay for $"+GetPricePerPayment()+" "+numPayments+" time(s).";
            }
            //return the message
            return message;
        }
    }
}