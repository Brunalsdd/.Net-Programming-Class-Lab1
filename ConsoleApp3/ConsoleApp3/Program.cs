using System.Linq;
using System.Text;
using System;

namespace ConsoleApp3
{
    using MyExtensions;
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is to test whether the extension method count can return a right answer or not");
            int i = sb.WordCount();
            System.Console.WriteLine("The number of words contained in sb is {0}", i);
        }
    }
}


namespace MyExtensions
{
    public static class StringExtension
    {
        public static int WordCount(this StringBuilder str)
        {
            return str.ToString().Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}

