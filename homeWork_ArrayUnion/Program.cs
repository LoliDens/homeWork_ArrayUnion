using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace homeWork_ArrayUnion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = new string[5] { "1", "2", "1", "4", "1" };
            string[] secondArray = new string[5] { "2", "3", "4","5","5" };

            List<string> uniqueValues = new List<string>();

            Console.Write("Первый массив: ");
            ShowArray(firstArray);

            Console.Write("Второй массив: ");
            ShowArray(secondArray);

            SelectUniqueValue(uniqueValues, firstArray);
            SelectUniqueValue(uniqueValues, secondArray);           

            Console.Write("Объедененный массивы в лист, без повторений: ");
            ShowList(uniqueValues);

            Console.ReadKey();
        }
      
        static void SelectUniqueValue(List<string> list, string[] array) 
        {
            for (int i = 0; i < array.Length; i++) 
            {
                string value = array[i];

                if (list.Contains(value) == false) 
                {
                    list.Add(value);
                }
            }               
        }      

        static void ShowList(List<string> list) 
        {
            for (int i = 0; i < list.Count; i++) 
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();
        }

        static void ShowArray(string[] array) 
        {
            for (int i = 0; i < array.Length; i++) 
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
