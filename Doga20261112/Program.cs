namespace Doga20261112
{
    internal class Program
    {
        static Random random = new Random();
        static string[] huto = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
        
        static void Takarit()
        {

        }

        static void KeresEtel()
        {
            Console.WriteLine("Melyik ételt szeretnéd megkeresni a hűtődben?");
            string etelNeve = Console.ReadLine();
            int index = 1;
            foreach (var item in huto)
            {
                if (item == etelNeve)
                {
                    Console.WriteLine("Ez az étel a "+index+". a hűtőben");
                }
                else
                {
                    index ++;
                }
            }
        }

        static void Feladat1()
        {
            //Takarit();
            KeresEtel();

        }
        static void Main(string[] args)
        { 
            Feladat1();
        }
    }
}
