using System;
using System.Text;

namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder united = new StringBuilder();
            for (int i = 0; i < args.Length; i++)
            {
                args[i] = args[i].ToUpper();
            }
            
            Array.Sort(args);
            
            united.Append(string.Join("-", args));

            if (args.Length == 0)
            {
                Console.WriteLine("NO ARGUMENTS");
            }

             Console.WriteLine(united);
        }
    }
}
