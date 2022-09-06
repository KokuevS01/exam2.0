using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Exam2
{
    public class Program
    {
        static void Main(string[] args)
        {
            TextWriterTraceListener myWriter = new TextWriterTraceListener(Console.Out);
            //Debug.Assert(false);    //Assertion Failed
            Trace.Listeners.Add(myWriter);
            Debug.AutoFlush = true;
            Debug.Indent();
            Trace.WriteLine("Trace");   //write Trace
            Debug.WriteLine("Debug");   //Don't write Debug
            Console.ReadLine();

        m: Console.WriteLine(" ");//ввод размерности
            int n = Int32.Parse(Console.ReadLine());
            double[,] a = new double[n, n];//массив матрицы
            double[] b = new double[n];//массив b
            double[] x = new double[n];// массив корней

            for (int i = 0; i < n; i++)
                x[i] = 0;

            Console.WriteLine(" ");
            //введение коэфициентов матрицы
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Введите х{j + 1} => ");
                    a[i, j] = double.Parse(Console.ReadLine());
                }
            Console.WriteLine(" ");
            //вывод
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($" {a[i, j]} ");

                }
                Console.Write(" " + b[i]);
                Console.WriteLine();
            }

            Console.WriteLine(" ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($" {a[i, j]} ");

                }
                Console.Write(" " + b[i]);
                Console.WriteLine();
            }


            {
                Console.Clear();//очистка
                goto m;
            }


            {
                string text = System.IO.File.ReadAllText(@"X:\экзамен\exam\Text.txt");

                System.Console.WriteLine("Contents of Text.txt = {0}", text);

                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");

                System.Console.WriteLine("Contents of WriteLines2.txt = ");
                foreach (string line in lines)
                {
                    Console.WriteLine("\t" + line);
                }

                Console.WriteLine("Press any key to exit.");
                System.Console.ReadKey();
            }
        }
    }
}
