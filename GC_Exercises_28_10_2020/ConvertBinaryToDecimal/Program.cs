using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GX_Exercises_28_10_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input a binary number: "); // of arbitrary length not just 4

            string binaryString = Console.ReadLine();

            isBinary(binaryString);



        }
        static void isBinary(string binaryString)
        {
            int isBinaryString = 0;
            foreach (char bitChar in binaryString)
            {
                if (bitChar == '1' || bitChar == '0')
                    isBinaryString++;
                else continue;
            }

            if (isBinaryString == binaryString.Length)
            {
                ConvertBinaryStringToDecimal(binaryString);
            }
            else
            {
                Console.WriteLine("You did not input a binary number");
            }
        }

        static void ConvertBinaryStringToDecimal(string binaryString)
        {
            double sum = 0;
            int k = binaryString.Length - 1;
            for (int i = 0; i < binaryString.Length; i++)
            {

                sum += ConvertBitAtGivenIndexFromBinaryToDecimal(ConvertBitCharToInt(binaryString[i]), k);
                k--;

            }
            Console.WriteLine($"{binaryString} corresponds to {sum}");
        }

        static double ConvertBitAtGivenIndexFromBinaryToDecimal(int bitAtEachIndex, int index)
        {
            double bitAtEachIndexToDecimal = bitAtEachIndex * Math.Pow(2, index);
            return bitAtEachIndexToDecimal;
        }


        static int ConvertBitCharToInt(char bitChar)
        {
            int bitAtEachIndex = int.Parse(bitChar.ToString());
            return bitAtEachIndex;
        }


    }


}