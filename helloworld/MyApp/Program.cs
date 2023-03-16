using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            for(i=0; i<10;i++){
                Console.WriteLine("Hello World!");
            }

            if(i < 10){
                Console.WriteLine("Hello World!" + i);
            }else if(i == 10)
            {
                Console.WriteLine("Hello World!" + i);
            }
            else
            {
                Console.WriteLine("Hello World!" + i);
            }

        }
    }
}
