using System;

namespace Twitter{
    
}

    
    class Program
    {
         
        public static void Main(string[] args)
        {
            Console.WriteLine("Compose your message:");
            string userInput = Console.ReadLine();

            if (userInput.Length > 140)
            {
                Console.WriteLine("Rejected");
            }
            else
            {
                Console.WriteLine("Posted");
            }

            Console.ReadKey();
        }
    }




  

