using System;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            Stack<string> stack = new Stack<string>();

            Queue<string> queue = new Queue<string>();

            HashSet<string> hashSet = new HashSet<string>();


            list.AddRange(new string[] { "D", "F", "V", "S", "V" });

            stack.Push("D");
            stack.Push("F");
            stack.Push("V");
            stack.Push("S");
            stack.Push("V");

            queue.Enqueue("D");
            queue.Enqueue("F");
            queue.Enqueue("V");
            queue.Enqueue("S");
            queue.Enqueue("V");

            hashSet.Add("D");
            hashSet.Add("F");
            hashSet.Add("V");
            hashSet.Add("S");
            hashSet.Add("V");

                    Console.WriteLine("List:");
            foreach (string letter in list)
            {
                Console.WriteLine(letter);
            }

            //Stacks
            Console.WriteLine("\nStack:");
            foreach (string letter in stack)
            {
                Console.WriteLine(letter);
            }

            //Queues
            Console.WriteLine("\nQueue:");
            foreach (string letter in queue)
            {
                Console.WriteLine(letter);
            }

            //HashSets
            Console.WriteLine("\nHashSet:");
            foreach (string letter in hashSet)
            {
                Console.WriteLine(letter);
            }
        } 
    }
}
        
