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
        private readonly List<object> _itemList;

        public Stack()
        {
            this._itemList = new List<object>();

        }

        public void Push(object item)
        {
            this._itemList.Add((object)item);

        }

        public object Pop()
        {
            var length = this._itemList.Count;

            if (length > 0)
            {
                object item = (object) this._itemList[length - 1];
                this._itemList.RemoveAt(length - 1);
                return item;
            }
            else
                throw new InvalidOperationException();

        }


    }
}
