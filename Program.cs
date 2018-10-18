using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3._1
{
  
    class Program
    {
        static void Main(string[] args)
        {
            //Array arr_ = new Array(4);
            Array arr = new Array();
            arr.ForWord="Массив1:";
            arr.PrintMas();
            int nach = 1;
            int pol;
            arr.Summ(ref nach, out pol );

            Console.WriteLine();

            Array2 arr2=new Array2(2,3);
            Array2 arr2_ = new Array2();
            Array2.Method();
            Array2 arr2__ = new Array2();
            
            


            arr2.PrintMas1();
            Console.WriteLine();
            arr2_.PrintMas1();
            Console.WriteLine();


            //Array3 el = new Array3(3); 

            For_last one = new For_last();
            Console.WriteLine(one.Equals("Nas"));
            Console.WriteLine(one.GetHashCode());
            Console.WriteLine(one.ToString());

        }

        public partial class Array
        {
            
            public readonly int[] mas = new int[3] { 8, 8, 8 };

            public const int a = 1;

            private string word;
            public string ForWord
            {
                set
                {
                    word = value;
                }
            }
        
            public void PrintMas()
            {
                Console.Write($"Массив{a}: ");
                foreach (int i in mas)
                {
                    Console.Write($"{i}\0");
                }

            }

            public static int s;
            static Array()
            {
                s = 0;
            }
               
            public void Summ(ref int i, out int pol_s )
            {
                while(i<mas.Length)
                {
                    s+=mas[i];
                    i++;
                }

                pol_s = s / 2;
                Console.Write($"\n\nСумма\0массива{a}: {s}");
                Console.Write($"\nПолусумма\0массива{a}: {pol_s}\n");
            }
        }


        class Array2
        {
            public static int count;

            public int[] mas2 = new int[4];

            public Array2(int a, int b) { mas2[1] =a ; mas2[2] = b; count++; }
            public Array2() { mas2[1] = 9; count++; }

            public void PrintMas1()
            {

                Console.Write("Массив2: ");
                foreach (int i in mas2)
                {
                    Console.Write($"{i}\0");
                }

            }

            public static void Method()
            {
                Console.WriteLine($"Счётчик объектов:\0{Array2.count}\n");
            }
                        
        }

        class Array3
        {
            public int[] mas3 = new int[2] { 4, 4 };
            
            private Array3(int z)
            {
                mas3[1] = z;
            }
                        
        }
       
        class For_last
        {
            public string one = "Nas"; 
            public override bool Equals(object obj)
            {
                For_last elem = new For_last();
                return (elem.one== (string)obj);
            }

            public char letter ='T';
            public override int GetHashCode()
            {
                return letter.GetHashCode();
            }

            public override string ToString()
            {
                return $"Информация об объекте:\n строка: {one}\n символ: {letter}";
            }
        }
            
    }
}
