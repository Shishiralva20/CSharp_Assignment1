using System;
namespace duplicate
{
    class Duplicates
    {
        public static void Main()
    

        {  
            int[] items = { 4, 3, 15, 2, 7, 5, 2, 12, 3, 6 };  
            int n = items.Length;  
  
            Console.WriteLine("Unique array elements are: ");  
  
            for(int i=0; i<n;i++)  
            {  
                bool Same = false;  
                for(int j=0;j<i;j++)  
                {  
                    if(items[i] == items[j])  
                    {  
                        Same = true;  
                        break;  
                    }  
                }  
  
                if(!Same)  
                {  
                    Console.WriteLine(items[i]);  
                      
                }  
            }  
  
            Console.ReadLine();  
        }  
    }
}