using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_git
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем массив
            Random random = new Random();
            int[] array = new int[10];
            Console.WriteLine("Массив до преобразования:");
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = random.Next(1, 20);
                Console.Write(Convert.ToString(array[j]) + " ");
            }
            //перезапись в массиве
            int check = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > 10)
                {
                    array[j] = 0;
                    check++;
                }
                else
                {
                    array[j] = 5;
                }

                if (check == 3)
                {
                    break;
                }
            }
            //вывод изменного массива
            Console.WriteLine();
            Console.WriteLine("Массив после преобразования:");
            int i = 0;
            while (i < 10)
            {
                Console.Write(Convert.ToString(array[i]) + " ");
                i++;
            }
            Console.WriteLine();
            //поиск чисел боль 10
            for (int j = 0; j < array.Length; j++)
            {
                switch (array[j])
                {
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                        Console.WriteLine("Больше 10 " + array[j]);
                        break; 
                }
            }
            Console.ReadKey();
        }
    }
}
