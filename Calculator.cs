using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
    
        static void Main(string[] args)
        {
        
                Console.WriteLine("Calculator");

                int angka1;
                int angka2;
                int pil;
                int total;

                Console.WriteLine("1. Penjumlahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian");

                Console.WriteLine("Silahkan pilih menu di atas : ");
                pil = int.Parse(Console.ReadLine());

                if (pil == 1)
                {
                    Console.WriteLine("Inputkan angka pertama :");
                    angka1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Inputkan angka kedua :");
                    angka2 = Convert.ToInt32(Console.ReadLine());

                    total = angka1 + angka2;
                    Console.WriteLine("Hasil : " + total);
                }
                else if (pil == 2)
                {
                    Console.WriteLine("Inputkan angka pertama :");
                    angka1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Inputkan angka kedua :");
                    angka2 = Convert.ToInt32(Console.ReadLine());

                    total = angka1 - angka2;
                    Console.WriteLine("Hasil : " + total);
                }
                else if (pil == 3)
                {
                    Console.WriteLine("Inputkan angka pertama :");
                    angka1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Inputkan angka kedua :");
                    angka2 = Convert.ToInt32(Console.ReadLine());

                    total = angka1 * angka2;
                    Console.WriteLine("Hasil : " + total);
                }
                else if (pil == 4)
                {
                    Console.WriteLine("Inputkan angka pertama :");
                    angka1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Inputkan angka kedua :");
                    angka2 = Convert.ToInt32(Console.ReadLine());

                    total = angka1 / angka2;
                    Console.WriteLine("Hasil : " + total);
                }
                else if (pil == 5)
                {
                    Console.WriteLine("Menu yang Anda pilih tidak tersedia");
                }
                Console.WriteLine("\nTekan apa saja untuk keluar");
                Console.ReadKey();
            }
        }

    }
