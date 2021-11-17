using System;

namespace oop_lab_rmkash
{
    public class Book
    {
        //instance variables
        private string name;
        private char gender;
        private string email;
        public Book(string tempName, char tempGender, string tempEmail)
        {
            name = tempName;
            gender = tempGender;
            email=tempEmail;
        }
        public string GetName()
        {
            return name;
        }
        public void SetIsbn(string tempName)
        {
            name = tempName;
        }
        public char GetGender()
        {
            return gender;
        }
        public void SetGender(char tempGender)
        {
            title = tempTitle;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string tempEmail)
        {
            email = tempEmail;
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