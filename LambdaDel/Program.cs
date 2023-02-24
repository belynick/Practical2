using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "Hello",
                "Goodbye",
                "HelloWorld",
                "someMessage"
            };

            for (int i = 0; i < list.Count; i++)
            {
            Func<string, int> returnLength;
            returnLength = (string text) => { return text.Length; };
            Console.WriteLine("Довжина рядка: " + returnLength(list[i]));
            }

            Console.ReadLine();
        }

        

     
}
}
