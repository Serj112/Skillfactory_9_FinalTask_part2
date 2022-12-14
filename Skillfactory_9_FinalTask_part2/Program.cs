using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillfactory_9_FinalTask
{
    public class Task
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ЗАДАНИЕ 1");

            int[] arr = { 2, 4, 6, 8, 0 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            try
            {
                Console.WriteLine(arr[10]);
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Есть исключение: {0}", e.Message);
            }

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Есть исключение: {0}", e.Message);
            }

            try
            {
                Console.WriteLine("Введите x: ");
                int x = int.Parse(Console.ReadLine());
            }

            catch (FormatException)
            {
                Console.WriteLine("Введено не числовое значение!");
            }

            try
            {
                File.Create(@"V:\Skillfactory\Exception.txt");
            }

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Есть исключение: {0}", e.Message);
            }

            try
            {
                string example = null;
                int example1 = int.Parse(example);
            }

            catch (ArgumentNullException e)
            {
                Console.WriteLine("Есть исключение: {0}", e.Message);
            }
            Console.WriteLine();

            LastNames pupkin = new LastNames("Pupkin");
            LastNames vasiliev = new LastNames("Vasiliev");
            LastNames dow = new LastNames("Dow");
            LastNames wayne = new LastNames("Wayne");
            LastNames crocket = new LastNames("Crocket");

            List<LastNames> lastNames = new List<LastNames> { pupkin, vasiliev, dow, wayne, crocket };

            Console.WriteLine("ЗАДАНИЕ 2.\nВведите 1, чтобы метод отработал в порядке возрастания; введите 2, чтобы метод отработал в порядке убывания");

            try
            {
                int v = int.Parse(Console.ReadLine());

                if (v == 1)
                {
                    lastNames.Sort(delegate (LastNames x, LastNames y)
                    {
                        return x.lastname.CompareTo(y.lastname);
                    });

                    Console.WriteLine(String.Join(Environment.NewLine, lastNames));
                }


                if (v == 2)
                {
                    lastNames.Sort(delegate (LastNames x, LastNames y)
                    {
                        return y.lastname.CompareTo(x.lastname);
                    });

                    Console.WriteLine(String.Join(Environment.NewLine, lastNames));
                }

                if (v != 2 && v != 1) { throw new Exception("Вы не ввели корректное число!"); }
            }

            catch (FormatException)
            {
                Console.WriteLine("Введено не числовое значение!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }
}