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

        m: Console.WriteLine(" Введите сумму, которую желаете положить в банк на вклад от 0 до 1 млн. у.е. ");//ввод размерности
            int n = Int32.Parse(Console.ReadLine());
            int[,] a = new int[n, n];//массив матрицы
            int[] b = new int[n];//массив b
            int[] x = new int[n];// массив корней
            int pr;
            int s = 8;
            int k = 12;
            int t = 1;
            for (int i = 0; i < n; i++)
                x[i] = 0;

            Console.WriteLine(" Вводим максимально допустимую процентную ставку ");
            //введение коэфициентов матрицы
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Введите х{j + 1} => ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine(" Вы положили в банк % у. е. ", x);
            //вывод
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($" {a[i, j]} ");
                }
                Console.Write(" Вычисление процентной ставки ");
                Console.Write(" Номинальная ставка будет равна 8%, срок капитализации равен 1 год. Количество капитализаций в год - 12. ");
                Console.WriteLine();
                pr = ((1 + s / (100 * k) ^ (k * t) - 1) * 100 / t); //формула для вычисления эффективной процентной ставки
                Console.Write(" Эффективная процентная ставка равна %X ", pr);
            }

            Console.WriteLine(" Оптимальная сумма для вашего вклада будет равняться: ", b);
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
                string text = System.IO.File.ReadAllText(@"X:\ekz2\exam2\ex.txt");

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
