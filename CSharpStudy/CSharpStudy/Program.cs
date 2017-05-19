using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string randStr = "Here are some random character";
            string randStr2 = "Here are some other random character";

            foreach(char c in randStr)
            {
                Console.Write(c);
            }
            foreach(char c in randStr2)
            {

            }
            Console.WriteLine("\nIs Empty : " + String.IsNullOrEmpty(randStr));
            Console.WriteLine("Is Empty(WhiteSpace) : " + String.IsNullOrWhiteSpace(randStr));
            Console.WriteLine(randStr.Length);
            Console.WriteLine("Index of are : " + randStr.IndexOf("are")); // 5
            Console.WriteLine("2nd Word is : " + randStr.Substring(5, 3)); // are
            Console.WriteLine("Is equal with")
        }
    }
}
