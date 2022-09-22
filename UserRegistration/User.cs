﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class User
    {
        //UC 1 Checkig for First Name Validation
        public const string FIRSTNAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public void FirstName(string firstname)
        {
            Regex regex = new Regex(FIRSTNAME_REGEX);
            bool result = regex.IsMatch(firstname);
            Console.WriteLine("UC-1: Entered First Name is " + result);
        }
        //UC 2 Checking for Last Name Validation
        public const string LASTNAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public void LastName(string lastname)
        {
            Regex regex = new Regex(LASTNAME_REGEX);
            bool result = regex.IsMatch(lastname);
            Console.WriteLine("\nUC-2: Entered Last Name is " + result);
        }
        //UC 3 Checking for Email Validation
        public const string EMAIL_REGEX = "^[a-z]{3}[.]{1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public void Email(string email)
        {
            Regex regex = new Regex(EMAIL_REGEX);
            bool result = regex.IsMatch(email);
            Console.WriteLine("\nUC-3: Entered Email is " + result);
        }
        //UC 4 Checking for Phone Number Validation
        public const string PHONENUMBER_REGEX = "^[91]*[ ]*[0-9]{10}$";
        public void PhoneNumber(string phonenumber)
        {
            Regex regex = new Regex(PHONENUMBER_REGEX);
            bool result = regex.IsMatch(phonenumber);
            Console.WriteLine("\nUC-4: Entered Phone Number is " + result);
        }
        //UC 5 Checking for Password of Minimum 8 Characters Validation
        public const string PASSWORD_REGEX = "^[A-Za-z0-9]{8,}$";
        public void Password(string password)
        {
            Regex regex = new Regex(PASSWORD_REGEX);
            bool result = regex.IsMatch(password);
            Console.WriteLine("\nUC-5: Entered Password is " + result);
        }
        //UC 6 Checking for Password of atleast 1 Upper case Validation
        public const string PASSWORD2_REGEX = "^[A-Z]+[A-Za-z0-9]{7,}$";
        public void Password2(string password2)
        {
            Regex regex = new Regex(PASSWORD_REGEX);
            bool result = regex.IsMatch(password2);
            Console.WriteLine("\nUC-6: Entered Password is " + result);
        }
    }
}
    

