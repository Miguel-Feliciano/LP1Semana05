using System;

namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            string united;
            for (int i = 0; i < args.Length; i++)
            {
                args[i] = args[i].ToUpper();
            }

            Array.Sort(args);

            united = string.Join("-", args);

            if (args.Length == 0)
            {
                Console.WriteLine("NO ARGUMENTS");
            }

             Console.WriteLine(united);
        }
    }
}
