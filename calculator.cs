using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            //int a = 10; //declarasi variabel dg nilai awal 10;
            //int b = 6; //declarasi variabel dg nilai awal 6;

            Console.WriteLine("Pilih Menu Calculator :");

            Console.WriteLine();

            double bil1, bil2;
            char Pilihan;
        menu:
            Console.WriteLine("*****************************************");
            Console.WriteLine("<<<<<<<<<< APLIKASI CALCULATOR >>>>>>>>>>");
            Console.WriteLine("*****************************************");
            Console.WriteLine("                                         ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("<<<<<<<<<<<<<< PILIHAN MENU >>>>>>>>>>>>>");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                                         ");
            Console.WriteLine("=========================================");
            Console.WriteLine("*              1. PENAMBAHAN            *");
            Console.WriteLine("*              2. PENGURANGAN           *");
            Console.WriteLine("*              3. PERKALIAN             *");
            Console.WriteLine("*              4. PEMBAGIAN             *");
            Console.WriteLine("*              5. EXIT                  *");
            Console.WriteLine("=========================================");
            //Console.WriteLine("\n");
            Console.WriteLine();

            Console.WriteLine("Input Nomor Menu : ");
            Pilihan = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");

            if (Pilihan == '1' || Pilihan == '1')
            {
            menu_1:
                Console.WriteLine("------------------------------------");
                Console.WriteLine("------------PENAMBAHAN--------------");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("Inputkan nilai a : ");
                bil1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b : ");
                bil2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" Hasilnya adalah: " + Penambahan(bil1, bil2) + "              ");
                Console.WriteLine("");
                Console.WriteLine("                    ~                 ");
                Console.WriteLine("                    ~                 ");
                Console.WriteLine("                    ~                 ");
                Console.WriteLine("");
                goto menu;
            }

            else if (Pilihan == '2' || Pilihan == '2')
            {
            menu_2:
                Console.WriteLine("------------------------------------");
                Console.WriteLine("------------PENGURANGAN-------------");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("Inputkan nilai a : ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b : ");
                bil2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Hasilnya adalah: " + Pengurangan(bil1, bil2) + "             ");
                Console.WriteLine("");
                Console.WriteLine("                    ~                 ");
                Console.WriteLine("                    ~                 ");
                Console.WriteLine("                    ~                 ");
                Console.WriteLine("");
                goto menu;
            }

            else if (Pilihan == '3' || Pilihan == '3')
            {
            menu_3:
                Console.WriteLine("------------------------------------");
                Console.WriteLine("--------------PERKALIAN-------------");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("Inputkan nilai a : ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b : ");
                bil2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Hasilnya adalah: " + Perkalian(bil1, bil2) + "               ");
                Console.WriteLine("");
                Console.WriteLine("                    ~                 ");
                Console.WriteLine("                    ~                 ");
                Console.WriteLine("                    ~                 ");
                Console.WriteLine("");
                goto menu;
            }

            else if (Pilihan == '4' || Pilihan == '4')
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("-------------PEMBAGIAN--------------");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("Inputkan nilai a : ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inputkan nilai b : ");
                bil2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Hasilnya adalah: " + Pembagian(bil1, bil2) + "               ");
                Console.WriteLine("");
                Console.WriteLine("                    ~                 ");
                Console.WriteLine("                    ~                 ");
                Console.WriteLine("                    ~                 ");
                Console.WriteLine("");
                goto menu;
            }

            else if (Pilihan == '5' || Pilihan == '5')
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("------------THANK YOU !!------------");
                Console.WriteLine("----------SEE YOU SOON :) ----------");
                Console.WriteLine("------------------------------------");
               
            }
            else
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("*     MENU YANG ANDA INPUTKAN SALAH     *");
                Console.WriteLine("*        KAMI KEMBALIKAN KE MENU        *");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("                     ~                   ");
                Console.WriteLine("                     ~                   ");
                Console.WriteLine("                     ~                   ");
                Console.WriteLine("");

                goto menu;
            } 

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
    }

        static double Penambahan(double a, double b)
        {
            return a + b;
        }

        static double Pengurangan(double a, double b)
        {
            return a - b;
        }

        static double Perkalian(double a, double b)
        {
            return a * b;
        }

        static double Pembagian(double a, double b)
        {
            return a / b;
        }
    }
}
