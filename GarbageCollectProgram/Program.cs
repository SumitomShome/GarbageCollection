using System;
namespace GarbageCollectProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            long mem1 = GC.GetTotalMemory(false);
            {
                //Allocate an array and make it unreachable
                int[] values = new int[50000];
                Console.WriteLine(values.Length);
                values = null;
            }
            long mem2 = GC.GetTotalMemory(false);
            {
                //Collect garbage
                GC.Collect();
            }
            long mem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(mem1);
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);
            }
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine("Press any key to close this window");
            Console.ReadKey();
        }
    }
}
