using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Брижак Андрей Домашняя работа 4 C# продвинутый
//Дана коллекция List<T>, требуется подсчитать, сколько раз каждый элемент встречается в
//данной коллекции.

namespace List_T
{
    class Program
    {
        static void Main(string[] args)
        {
            //требуется подсчитать, сколько раз каждый элемент встречается в данной коллекции для целых чисел using System.Collections;
            ArrayList list = new ArrayList();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int c = rnd.Next(1, 4);
                list.Add(c);
                //Console.WriteLine(c);
            }

            foreach (object element in list)
                Console.WriteLine(element);
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

            foreach (object element in list)
                if (1.Equals(element))
                {
                    count1++;
                }

                else if (2.Equals(element))
                {
                    count2++;
                }

                else if (3.Equals(element))
                {
                    count3++;
                }

                else if (4.Equals(element))
                {
                    count4++;
                }
            Console.WriteLine("1 " + " - " + count1 + " раз");
            Console.WriteLine("2 " + " - " + count2 + " раз");
            Console.WriteLine("3 " + " - " + count3 + " раз");
            Console.WriteLine("4 " + " - " + count4 + " раз");
            Console.ReadKey();

            List<int> a = new List<int> { 1, 2, 4, 3, 5, 4, 4, 2, 6 };
            foreach (object element in a)
                Console.WriteLine(element);
            Console.ReadKey();
            Console.WriteLine("Подсчитать, сколько раз каждый элемент встречается вданной коллекции используя Linq");
            foreach (int val in a.Distinct())
            {
                Console.WriteLine(val + " - " + a.Where(x => x == val).Count() + " раз");
                
            }
            Console.ReadKey();
                     
        }
    }
}
