using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
         string myString = "Hello, World!";

        //  int counter = 0;
        //  while (counter < myString.Length)
        //  {
        //    Console.WriteLine($"String index {counter} is {myString[counter]}.");
        //    counter++;
           
        //  } 
        //   Console.WriteLine("Done");

        // for (int i = 0; i < myString.Length; i++) //counting up
        for (int i = myString.Length-1; i >= 0; i--) //counting down (note: For myString.Length-1, the -1 is required cause without it will be counting ouside as 'positon 13')
        {
          Console.WriteLine($"String index {i} is {myString[i]}.");
        }

        }
    }
}
