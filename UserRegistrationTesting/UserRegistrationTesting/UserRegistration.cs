using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationTesting
{
    public class UserRegistration
    {
        //This method for matching pattern of first name
        public static string FirstNameValid(string name)
        {
            //Regular expression for first letter is capital and maximum charactor is 3
            string firstname = "^[A-Z]{1}[a-zA-Z]{2}$";
            Regex regex = new Regex(firstname);
            //if condition for matching pattern
            //if condition is true then if block will execute
            if (regex.IsMatch(name))
            {
                //Console.WriteLine(name + " is valid name");
                return "valid";
            }
            //else condition for if condition is false then else block will execute
            else
            {
                //Console.WriteLine(name + " is invalid first name. Please start with capital letter and only take maximum 3 charactors");
                return "invalid";
            }
        }
        //This method for validate last name
        public static string LastNameNameValid(string name)
        {
            //Regular expression for first letter is capital and maximum charactor is 3
            string lastName = "^[A-Z]{1}[a-zA-Z]{2}$";
            Regex regex = new Regex(lastName);
            //if condition for matching pattern
            if (regex.IsMatch(name))
            {
                //Console.WriteLine(name + " is valid name");
                return "valid";
            }
            //else condition for if condition is false then else block will execute
            else
            {
                //Console.WriteLine(name + " is invalid last name. Please start with capital letter and take maximums 3 charactors");
                return "invalid";
            }
        }
        //This method for validation of email id
        public static string EmailValid(string name)
        {
            //Regular expression of email id
            string emailid = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][0-9a-zA-Z]+[.][a-zA-Z]{2,4}([a-zA-Z]{2,3}){0,1}";
            Regex regex = new Regex(emailid);

            if (regex.IsMatch(name))
            {
                //Console.WriteLine("Email Id is valid");
                return "valid";
            }
            else
            {
                //Console.WriteLine("Email Is Invalid,Please Enter Valid Email Id.");
                return "invalid";
            }

        }
        //This method for validation of mobile number
        public static string MobileNumValid(string num)
        {
            //Regular expression of mobile number
            string number = "^[0-9]{1,2}[ ]{1}[0-9]{10}$";
            Regex regex = new Regex(number);

            if (regex.IsMatch(num))
            {
                //Console.WriteLine("Mobile Number is valid");
                return "valid";
            }
            else
            {
                //Console.WriteLine("Mobile number is Invalid,Please Enter Valid MObile Number format.");
                return "invalid";
            }

        }

    }
}
