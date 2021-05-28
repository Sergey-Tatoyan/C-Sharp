using System;

namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ids = {4, 6, 0, 1, 23, 5, 67, 36};
            for (int j = 0; j < ids.Length - 1; j++)
            {
                for (int k = 0; k < ids.Length - 1; k++)
                {
                    if (ids[k] > ids[k + 1])
                    {
                        int a;
                        a = ids[k + 1];
                        ids[k + 1] = ids[k];
                        ids[k] = a;
                    }
                }
            }
            Console.WriteLine("Hello -)))");
            foreach (int p in ids)
                Console.Write(p + " ");

            Console.WriteLine();
            
            int[,,] array = { { { 1, 2 },{ 3, 4 } },

                { { 4, 5 }, { 6, 7 } },

                { { 7, 8 }, { 9, 10 } },

                { { 10, 11 }, { 12, 13 } }

            };

            int index = 0;
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                       arr[index] = array[i, j, k];
                        index++;
                    }
                    
                }
            }

            Console.WriteLine("Hello -)))");
            foreach (int p in arr)
                Console.Write(p + " ");
        }
    }
}