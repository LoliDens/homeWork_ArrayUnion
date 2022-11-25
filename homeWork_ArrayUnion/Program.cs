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

            List<string> result = new List<string>();

            Console.Write("Первый массив: ");
            PrintArray(firstArray);
            Console.Write("Второй массив: ");
            PrintArray(secondArray);

            UnionArraysInList(result, firstArray, secondArray);
            Console.Write("Объедененный массивы в лист, без повторений: ");
            PrintList(result);

            Console.ReadKey();
        }

        static void UnionArraysInList(List<string> list, string[] firstArray, string[] secondArray) 
        {
            WriteFormArrayToList(list, firstArray);
            WriteFormArrayToList(list, secondArray);

            DeleteRepeat(list);
        }

        static void DeleteRepeat(List<string> list) 
        {
            for (int i = 0; i < list.Count;i++) 
            {
                bool isRepeat = false;

                for (int j = i + 1; j < list.Count; j++) 
                {
                    if (list[i] == list[j]) 
                    {
                        isRepeat = true;
                        break;
                    }
                }

                if (isRepeat == true)
                {
                    list.RemoveAt(i);
                    i--;
                }                
            }
        }

        static void WriteFormArrayToList(List<string> list, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
            }
        }

        static void PrintList(List<string> list) 
        {
            for (int i = 0; i < list.Count; i++) 
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();
        }

        static void PrintArray(string[] array) 
        {
            for (int i = 0; i < array.Length; i++) 
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

    }
}
