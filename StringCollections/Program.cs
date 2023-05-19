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
        }
    }
}
