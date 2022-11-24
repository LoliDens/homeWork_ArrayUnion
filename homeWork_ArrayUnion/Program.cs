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
            string[] firstArray = new string[3] { "1", "2", "1" };
            string[] secondArray = new string[3] { "2", "3", "4" };

            List<string> result = new List<string>();

            Console.Write($"Первый массив: ");
            PrintArray(firstArray);
            Console.Write("Второй массив: ");
            PrintArray(secondArray);
            
            result = CreateListForArrays(firstArray, secondArray);
            Console.Write("Объединенный в каллекцию массивы, без повторений: ") ;
            PrintList(result);

            Console.ReadKey();
        }

        static List<string> CreateListForArrays(string[] firstArray, string[] secondArray)
        {
            string[] temporaryArray = new string[0];
            List<string> result = new List<string>();

            firstArray = DeleteRepeats(firstArray);
            secondArray = DeleteRepeats(secondArray);

            temporaryArray = UnionArrays(firstArray, secondArray);

            for (int i = 0; i < temporaryArray.Length; i++) 
            {
                result.Add(temporaryArray[i]);
            }

            return result;
        }

        static string[] UnionArrays(string[] firstArray, string[] secondArray)
        {
            string[] result = new string[0];

            result = AppendingToArray(result, firstArray);
            result = AppendingToArray(result, secondArray);

            result = DeleteRepeats(result);

            return result;
        }

        static string[] DeleteRepeats(string[] array)
        {
            string[] temporaryArray = new string[1] { array[0] };

            for (int i = 0; i < array.Length; i++)
            {
                bool isRepeat = false;

                for (int j = 0; j < temporaryArray.Length; j++)
                {
                    if (array[i] == temporaryArray[j])
                    {
                        isRepeat = true;
                    }
                }

                if (isRepeat == false)
                {
                    temporaryArray = ExpansionArray(temporaryArray, array[i]);
                }
            }

            array = temporaryArray;
            return array;
        }

        static string[] ExpansionArray(string[] array, string elemnet)
        {
            string[] temporaryArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                temporaryArray[i] = array[i];
            }

            temporaryArray[temporaryArray.Length - 1] = elemnet;
            array = temporaryArray;
            return array;
        }

        static string[] AppendingToArray(string[] WrinteArray, string[] ReadArray) 
        {          
            for (int i = 0; i < ReadArray.Length; i++)
            {
                WrinteArray = ExpansionArray(WrinteArray, ReadArray[i]);
            }

            return WrinteArray;
        }

        static void PrintArray(string[] array) 
        {
            for (int i = 0; i < array.Length; i++) 
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        static void PrintList(List<string> list) 
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
