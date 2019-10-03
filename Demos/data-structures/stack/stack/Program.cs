using System;
using System.Collections;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //nongeneric collection, last in first out, push/pop
            //create stack
            Stack stack = new Stack();

            //add to stack
            stack.Push("david");
            stack.Push("derek");
            stack.Push("donny");
            stack.Push("dan");
            
            //display
            foreach (var item in stack)
                Console.WriteLine(item);

            //remove from stack
            stack.Pop();
            //display
            foreach (var item in stack)
                Console.WriteLine(item);
        }
    }
}
