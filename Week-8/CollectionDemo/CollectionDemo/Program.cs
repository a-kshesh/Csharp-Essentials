using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String mary = "Mary had a little lamb. It's a fleece was white as snow.";
            //ListDemo(mary);
            //StackDemo(mary);
            DictionaryDemo();
        }

        static void ListDemo(String str)
        {
            List<String> grt = new List<string>();
            foreach (string word in str.Split())
            {
                grt.Add(word);
            }
            Console.WriteLine(String.Join(" ,", grt));
            String toFind = "little";
            Console.WriteLine($"{toFind} is {(grt.Contains(toFind) ? "" : "not")} present.");
            grt.Sort();
            Console.WriteLine(grt.BinarySearch(toFind));
        }
        static void StackDemo(String str)
        {
            Stack<String> stack = new Stack<string>(str.Split());
            Console.WriteLine($" Number of items{stack.Count}");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        static void DictionaryDemo()
        {
            Dictionary<String, String> dict = new Dictionary<string, string>();
            dict.Add("doc", "winword.exe");
            dict.Add("txt", "notepad.exe");
            dict.Add("bmp", "paint.exe");
            dict.Add("xls", "excel.exe");
            dict.Add("png", "paint.exe");
            dict.Add("html", "chrome.exe");

            foreach (KeyValuePair<String, string> pair in dict)
            {
                Console.WriteLine($"{pair.Key}---{pair.Value}");
            }

            Console.WriteLine("keys");
            foreach (var key in dict.Keys)
            {
                Console.WriteLine(key);
            }
        }

        static void SortedListDemo()
        {
            SortedList<String, String> sort = new SortedList<string, string>();
            sort.Add("doc", "winword.exe");
            sort.Add("txt", "notepad.exe");
            sort.Add("bmp", "paint.exe");
            sort.Add("xls", "excel.exe");
            sort.Add("png", "paint.exe");
            sort.Add("html", "chrome.exe");

            foreach (KeyValuePair<String, string> pair in sort)
            {
                Console.WriteLine($"{pair.Key}---{pair.Value}");
            }

        }
    }

}
