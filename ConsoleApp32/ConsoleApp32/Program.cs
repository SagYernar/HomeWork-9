using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                11,22,33,44,55,66,77,88,99,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127
            };

            Console.WriteLine("Индекс: {0} --- Значение: {1}",numbers.Count-2, numbers[numbers.Count - 2]);
            Console.ReadLine();

            int sum = 0;
            for(int i = 0; i < numbers.Count; i+=2)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Сумма четных элементов коллекции: {0}",sum);
            Console.ReadLine();
        }
    }
}
