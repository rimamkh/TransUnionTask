using System;

namespace Ceaser_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            CeaserClass myclass = new CeaserClass();
            Console.WriteLine("Press 1 to complete " + "\n" + "Press 2 to quit");
            int input = Convert.ToInt32(Console.ReadLine());
            while (input == 1)
            {
                Console.WriteLine("enter your string to encrypt it: ");
                string Userinput = Console.ReadLine();
               
                Console.Write("Enter your Key: ");
                int keyshift = Convert.ToInt32(Console.ReadLine());
                
                myclass.Encipher(Userinput, keyshift);
                Console.WriteLine("Encrypted message: ");

                Console.WriteLine(myclass.Encipher(Userinput, keyshift));
                Console.WriteLine("=============================");
                
                Console.WriteLine("Press 1 to complete " + "\n" + "Press 2 to quit");
                input = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("if you want to quite press enter key");
            Console.ReadKey();


        }
    }
}
