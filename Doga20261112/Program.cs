namespace Doga20261112
{
    internal class Program
    {
        static Random random = new Random();
        static string[] huto = { "Tej", "", "", "", "Alma", "", "h", "", "Ananász" };
        static int[] szamok = new int[10];
        
        static void Takarit()
        {
            int darabszam = 0;
            string[] seged = new string[huto.Length];
            int y = 0;
            for (int i = 0; i < huto.Length; i++, y++)
            {
                if (huto[i] != "")
                {
                    seged[y] = huto[i];
                }
            }
            for (int i = 0; i < seged.Length; i++)
            {
                Console.WriteLine(seged[i]);  
            }
            for (int i = 0; i < huto.Length; i++)
            {
               if (huto[i] == "")
               {
               }
               else
               {
                    darabszam++;
               }
            }
            Console.WriteLine(darabszam);
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
                else if (index == 10 && item != etelNeve)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    index ++;
                }
            }
        }

        static void maganhangzo()
        {
            string maganhangzok = "aáeéöőüűií";
            foreach (var item in huto)
            {
                if (item != "") { 
                    char elsoKarakter = char.ToLower(item[0]);
                    if (maganhangzok.Contains(elsoKarakter))
                    {
                        Console.WriteLine(item);
                    }
                }

            }
        }


        static int[] FeltoltEgyediekkel(int min, int max)
        {
            int veletlenszam = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                veletlenszam = random.Next(min, max + 1);
                szamok[i] = veletlenszam;
            }

            return szamok;
        }

        static void feladat2()
        {
            Console.WriteLine("Mennyi legyen a minimum értéke a számaidnak?");
            int min = 10;

            Console.WriteLine("Mennyi legyen a maximum értéke a számaidnak?");
            int max = 30;

            FeltoltEgyediekkel(min, max);
        }


        static void feladat1()
        {
            //Takarit();
            KeresEtel();
            maganhangzo();

        }
        static void Main(string[] args)
        {
            feladat1();
            //feladat2();
        }
    }
}
