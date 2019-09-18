using System;
using System.Collections.Generic;

namespace Stack_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }

    public class Stack
    {

        public List<object> ItemList;

        public Stack()
        {
            this.ItemList = new List<object>();

        }

        public void Push(object item)
        {
            this.ItemList.Add((object)item);

        }

        public object Pop()
        {
            var length = this.ItemList.Count;

            if (length > 0)
            {
                object item = (object) this.ItemList[length - 1];
                this.ItemList.RemoveAt(length - 1);
                return item;
            }
            else
                throw new InvalidOperationException();

        }


    }
}
