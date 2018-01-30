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
            ArrayList list = new ArrayList();
            Random rnd = new Random     ;
            list.Add( 1 );
            list.Add(1);

            List<int> a = new List<int> { 1, 2, 4, 3, 5, 4, 4, 2, 6 };
            Console.WriteLine("Подсчитать, сколько раз каждый элемент встречается вданной коллекции используя Linq");
            foreach (int val in a.Distinct())
            {
                Console.WriteLine(val + " - " + a.Where(x => x == val).Count() + " раз");
                
            }
            Console.ReadKey();
                     
        }
    }
}
