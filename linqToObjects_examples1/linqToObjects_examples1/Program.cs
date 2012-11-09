/* Author: Me (of course)
 * Example taken from book: linq to objects using c# 4.0
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace linqToObjects_examples1
{
    class Program
    {
        static void Main(string[] args)
        {
            //String password = "ClearTextPassword";
            //String hashpassword = password.GetSHA1Hash();

            //Console.WriteLine("pw: {0}", password);
            //Console.WriteLine("hashedpw: {0}", hashpassword);

            var items = new {name = "car", make = "honda"};
            Console.WriteLine("type = {0}, name = {1}, make = {2}",
                items.GetType().ToString(), items.name, items.make);

            Console.ReadLine();
        }
    }

    public static class MyStringExtensions
    {
        public static String GetSHA1Hash(this String text)
        {
            if (String.IsNullOrEmpty(text))
                return null;

            SHA1Managed sha1 = new SHA1Managed();

            Byte[] bytes = sha1.ComputeHash(new UnicodeEncoding().GetBytes(text));

            return Convert.ToBase64String(bytes);
        }
    }
}
