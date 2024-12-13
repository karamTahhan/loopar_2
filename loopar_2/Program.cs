using System;

namespace loopar_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ett heltal");
            string str=Console.ReadLine();
            int tal= int.Parse(str);
            while(tal!=0)
            {
                Console.WriteLine("skriv igen (skriv in 0 för att avsluta");
                str = Console.ReadLine();
                tal = int.Parse(str);


            }
            Console.WriteLine("du har avslutat programmet");


            
            

        }

    }

}