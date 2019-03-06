using System;
using System.Linq;
using System.IO;

namespace error
{
    class errore
    {
        private static void Main()
        {
            Console.SetCursorPosition(25,90);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                 StreamReader str = new StreamReader("error.log");
                 string a = str.ReadLine();
                 string b = str.ReadLine();
                 Console.Write("          :( Se ha producido un error en la API.Lo sentimos. Esta la informacion de los logs          \n           Tipo de error: " + a + " Numero de Revision: " + b );
                 Console.ReadLine();
            }
            catch(Exception)
            {
                Console.Write("No0X0");
            }

        }
    }
}