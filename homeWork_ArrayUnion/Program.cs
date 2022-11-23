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

            string[] result = UnionArrays(firstArray, secondArray);
            OutputArray(result);
            Console.ReadKey();
        }

        static string[] UnionArrays(string[] firstArrray, string[] secondArray)
        {
            firstArrray = DeleteRepeatsInArray(firstArrray);
            secondArray = DeleteRepeatsInArray(secondArray);

            string[] result = UnionWithoutRepetition(firstArrray, secondArray);

            return result;
        }
               
        static string[] DeleteRepeatsInArray(string[] array)
        {
            string[] temporaryArray = new string[1] { array[0] };

            temporaryArray = UnionWithoutRepetition(temporaryArray, array);

            array = temporaryArray;
            return array;
        }

        static string[] UnionWithoutRepetition(string[] firstArrray, string[] secondArray) 
        {
            for (int i = 0; i < secondArray.Length; i++)
            {
                bool isRepeat = false;

                for (int j = 0; j < firstArrray.Length; j++)
                {
                    if (secondArray[i] == firstArrray[j])
                    {
                        isRepeat = true;
                    }
                }

                if (isRepeat == false)
                {
                    firstArrray = ExtensionArray(firstArrray, secondArray[i]);
                }
            }

            return firstArrray;
        }

        static void OutputArray(string[] array) 
        {
            for (int i = 0; i < array.Length; i++) 
            {
                Console.Write(array[i] + " ");
            }
        }

        static string[] ExtensionArray(string[] array, string elemet)
        {
            string[] temporaryArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                temporaryArray[i] = array[i];
            }

            temporaryArray[temporaryArray.Length - 1] = elemet;
            array = temporaryArray;

            return array;
        }


    }
}
