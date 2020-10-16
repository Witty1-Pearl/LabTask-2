using System;

namespace Task4
{
    class Program
    {
            static void Main()  
        {  
                    
                int[] list = {56, 42, 100, 2, 10};
              
                Console.WriteLine("Original Unsorted List");
                
                
                foreach (int i in list) {
                    Console.Write(i + " ");
                }
                Array.Sort(list);
               
                Console.WriteLine("\nSorted List");
                
                
                for(int i=0; i<list.Length; i++) {
                    Console.Write(list[i] + " ");
                }
        }  
    }
}
