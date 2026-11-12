namespace Doga20261112
{
    internal class Program
    {
        static Random random = new Random();
        static string[] huto = { "Tej", "", "Saláta", "", "Alma", "", "Sajt", "", "Ananász" };
        
        static void Takarit()
        {
            string[] seged = new string[huto.Length];
            int y = 0;
            for (int i = 0; i < huto.Length; i++)
            {
                if (huto[i] != "")
                {
                    seged[y] = huto[i];
                    y++;
                }
            }
            huto = seged;
            int darabszam = 0;
            for (int i = 0; i < huto.Length; i++)
            {
                if (huto[i] != null)
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
                if (item != null) { 
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
            int[] tomb = new int[10];
            int veletlenszam = 0;
            bool van = false;
            for (int i = 0; i < 10; i++)
            {
                veletlenszam = random.Next(min, max);
                if (tomb.Contains(veletlenszam))
                {
                    van = true;
                    while ( van == true )
                    {
                        veletlenszam = random.Next(min, max);
                        if (tomb.Contains(veletlenszam) == false )
                        {
                            van = false;
                            tomb[i] = veletlenszam;
                        }
                    }
                }
                else
                {
                    tomb[i] = veletlenszam;
                }
            }
            return tomb;
        }

        static void feladat2()
        {
            Console.WriteLine("Mennyi legyen a minimum értéke a számaidnak?");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mennyi legyen a maximum értéke a számaidnak?");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] szamok = FeltoltEgyediekkel(min, max);
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }
        }


        static void feladat1()
        {
            Takarit();
            KeresEtel();
            maganhangzo();

        }
        static void Main(string[] args)
        {
            //feladat1();
            feladat2();
        }
    }
}
