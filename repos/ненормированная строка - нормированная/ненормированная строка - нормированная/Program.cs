using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ненормированная_строка___нормированная
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = " Hello   world  ";
            string[] newtext = text.Split(new char[] {' ' }, StringSplitOptions.RemoveEmptyEntries);
            text = String.Join(" ", newtext);
            //text = text.Trim();
            //string newtext = "";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == ' ' && text[i + 1] == ' ') { }
            //    else newtext = newtext + text[i];
            //}
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
