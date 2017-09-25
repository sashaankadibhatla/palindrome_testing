using System;

namespace palindrome_code
{
    class Program 
    {
        static void Main()
        {
            Console.WriteLine("Enter a string");
            string str1 = Console.ReadLine();
            
            Palindrom palin= new Palindrom();
            palin.IsPalindrom(str1);
           
            
        }
    }

   public class Palindrom
    {
        public bool IsPalindrom(string str)
        {
            string revrse="";
           
             for (int i = str.Length-1; i >=0; i--) //String Reverse
            {
                revrse += str[i].ToString();
            }
            if (revrse == str) 
            {   
                Console.WriteLine("String is a palindrome");
                return true;
            }
            else
            {   
                Console.WriteLine("String is not a palindrome");
                return false;
            }
           
        }
    }
}
