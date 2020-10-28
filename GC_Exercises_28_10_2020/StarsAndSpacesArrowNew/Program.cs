using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsSpaces
{
    class Program
    {
        static void Main(string[] args)
        {

            CreateDoubleArrow();


            /*    ^         ^
             *   ^^         ^^
             *  ^^^^^^^^^^^^^^^  
             * ^^^^^^^^^^^^^^^^^
             *  ^^^^^^^^^^^^^^^
             *   ^^         ^^ 
             * ?  ^         ^
             */

            //needs 1) max no of spaces before triangle base : 4
            //      2) length of triangle base : 2
            //      3) spaces between trianles : 9
            //      4) symbol to create double arrow: ^

        }



   
        static void CreateDoubleArrow()
        {
            Console.Write("Enter maximum base length of triangle: ");
            int triangleBase = int.Parse(Console.ReadLine());
            Console.Write("Enter maximum length of spaces before/after triangle base: ");
            int spaceBeforeBase = int.Parse(Console.ReadLine());
            Console.Write("Enter maximum length of spaces between triangles: ");
            int spaceBetweenTriangles = int.Parse(Console.ReadLine());
            Console.Write("Enter symbol to draw double arrow: ");
            char symbol = char.Parse(Console.ReadLine());
            DoubleArrow(spaceBeforeBase, triangleBase, spaceBetweenTriangles, symbol);



        }



        static string XSymbol(int noOfSymbols, char symbol)
        {
            string symbolString = "";
            for (int i = 0; i < noOfSymbols; i++)
            {
                symbolString += symbol;
            }
            return (symbolString);
        }


        static string XSpaces(int noOfSpaces)
        {
            string spaces = "";
            for (int i = 0; i < noOfSpaces; i++)
            {
                spaces += " ";
            }
            return (spaces);
        }

        static void DoubleArrow(int spaceBeforeBase, int triangleBase, int spaceBetweenTriangles, char symbol)
        {
            
            TopPart(spaceBeforeBase, triangleBase, spaceBetweenTriangles,symbol);
            BottomPart(spaceBeforeBase, triangleBase, spaceBetweenTriangles, symbol);
            

        }

        static void TopPart(int spaceBeforeBase, int triangleBase, int spaceBetweenTriangles, char symbol)
        {
            int arrowHeight = spaceBeforeBase + triangleBase;
            for (int i = 0; i <= arrowHeight; i++)
            {
                if (i <= triangleBase)
                {
                    Console.WriteLine(XSpaces(arrowHeight - i) + XSymbol(i, symbol) + XSpaces(spaceBetweenTriangles) + XSymbol(i, symbol) + XSpaces(arrowHeight - i));
                }
                else
                {
                    Console.WriteLine(XSpaces(arrowHeight - i) + XSymbol(i, symbol) + XSymbol(spaceBetweenTriangles, symbol) + XSymbol(i, symbol) + XSpaces(arrowHeight - i));
                }

            }
        }

        static void BottomPart(int spaceBeforeBase, int triangleBase, int spaceBetweenTriangles, char symbol)
        {

            int arrowHeight = spaceBeforeBase + triangleBase;
            for (int i = 0; i<=arrowHeight-1; i++)
            {
                if (i <spaceBeforeBase)
                {
                    Console.WriteLine(XSpaces(i) + XSymbol(arrowHeight - i, symbol) + XSymbol(spaceBetweenTriangles, symbol) + XSymbol(arrowHeight - i, symbol));

                }
                else
                {
                    Console.WriteLine(XSpaces(i) + XSymbol(arrowHeight - i, symbol) + XSpaces(spaceBetweenTriangles) + XSymbol(arrowHeight - i, symbol));
                }





            }
        }

        }
}
