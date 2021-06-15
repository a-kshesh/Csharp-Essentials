using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGenericDemo
{
  class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>(999);
            list.Add(555);
            list.Add(13);
            list.Add(23);
            Console.WriteLine(list);

            LinkedList<String> list1 = new LinkedList<string>("ABCD");
            list1.Add("EFGH");
            Console.WriteLine(list1);
            string[] str = new string[] { "abc","Cd","eg"};
            LinkedList<String[]> list2 = new LinkedList<string[]>(str);
            
            Console.WriteLine(list2);
        }
    }

    class Node<T>
    {
        public T Data { get; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return $"{Data}";
        }
    }

    class LinkedList<T>
    {
        public Node<T> Root { get; }
        public Node<T> Current { get; set; }


        public LinkedList(Node<T> node)
        {
            this.Root = node;
            this.Current = node;

        }
        public LinkedList(T node)
            :this(new Node<T> (node))
        {
        }

        public void Add(Node<T> node)
        {
            this.Current.Next = node;
            this.Current = node;
           
        }

        public void Add(T data)
        {
            Add(new Node<T> (data));
        }

        public void Add(T[] data)
        {
            foreach (T data1 in data)
            {
                Add(data1);
            }
        }
        
        
        public override string ToString()
        {
            String result = string.Empty;
            Node<T> present = Root;

            while (present != null)
            {
                result += present + " ";
                present = present.Next;
            }
            return result;
        }
    }
}
