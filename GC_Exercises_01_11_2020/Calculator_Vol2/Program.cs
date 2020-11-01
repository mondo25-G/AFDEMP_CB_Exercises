using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Vol2
{
    class Program
    {
        static void Main(string[] args)
        {
            //UNCOMMENT FROM TEST 1 TO TEST 3 TO CHECK PROGRAM FOR DEFAULT CONSTRUCTORS
            //
            //UNMCOMMENT FROM TEST 4 TO TEST 6 TO CHECK PROGRAM FOR OVERLOADED CONSTRUCTORS


            //Or switch input numbers anywhere.


            //// Test 1: default constructor :default methods

            //Console.WriteLine("Test for Default constructor: default methods");
            //Calculator calc = new Calculator();
            //same for overloaded Calculator calc = new Calculator(0,0);

            //Console.WriteLine(calc.Operations('/')); 

            //calc.TellMePleaseTheValuesOfTheFields();//0,0
            //Console.WriteLine(calc.Add());//0
            //calc.TellMePleaseTheValuesOfTheFields();//0,0
            //Console.WriteLine(calc.Subtract());//0
            //calc.TellMePleaseTheValuesOfTheFields();//0,0
            //Console.WriteLine(calc.Multiply());//0
            //calc.TellMePleaseTheValuesOfTheFields();//0,0
            //Console.WriteLine(calc.Divide());//0
            //calc.TellMePleaseTheValuesOfTheFields();//0,0

            // //Test 2: default constructor: overloaded methods
            //Console.WriteLine("Test for Default constructor: overloaded methods");

            //calc.TellMePleaseTheValuesOfTheFields();//0,0
            //Console.WriteLine(calc.Add(2, -3));//-1
            //calc.TellMePleaseTheValuesOfTheFields();//2,-3
            //Console.WriteLine(calc.Subtract(-4, 9));//-13
            //calc.TellMePleaseTheValuesOfTheFields();//-4,9
            //Console.WriteLine(calc.Multiply(-2, -5));//10
            //calc.TellMePleaseTheValuesOfTheFields();//-2,-5
            //Console.WriteLine(calc.Divide(4, 3));//1
            //calc.TellMePleaseTheValuesOfTheFields();//4,3
            //Console.WriteLine(calc.Divide(80, 3));//26
            //calc.TellMePleaseTheValuesOfTheFields();//80,3
            //Console.WriteLine(calc.Divide(7, 0));//7
            //calc.TellMePleaseTheValuesOfTheFields();//7,0
            //Console.WriteLine(calc.Multiply(10, 5));//50
            //calc.TellMePleaseTheValuesOfTheFields();//10,5

            //// Test 3: default constructor :default methods + overloaded methods:
            //Console.WriteLine("Test for Default constructor: default methods + overloaded methodss");

            //calc.TellMePleaseTheValuesOfTheFields();//0,0
            //Console.WriteLine(calc.Add(3, 0));//
            //calc.TellMePleaseTheValuesOfTheFields();//3,0
            //Console.WriteLine(calc.Divide());//0
            //calc.TellMePleaseTheValuesOfTheFields();//3,0
            //Console.WriteLine(calc.Subtract());//3
            //calc.TellMePleaseTheValuesOfTheFields();//3,0
            //Console.WriteLine(calc.Subtract(-4, 9));//-13
            //calc.TellMePleaseTheValuesOfTheFields();//-4,9
            //Console.WriteLine(calc.Multiply(-2, -5));//10
            //calc.TellMePleaseTheValuesOfTheFields();//-2,-5
            //Console.WriteLine(calc.Divide(4, 3));//1
            //calc.TellMePleaseTheValuesOfTheFields();//4,3
            //Console.WriteLine(calc.Multiply());//12
            //calc.TellMePleaseTheValuesOfTheFields();//4,3
            //Console.WriteLine(calc.Add(-2, 3));// 1
            //calc.TellMePleaseTheValuesOfTheFields();
            //Console.WriteLine(calc.Divide());//0
            //calc.TellMePleaseTheValuesOfTheFields();//-2,3
            //Console.WriteLine(calc.Divide(80, 3));//26
            //calc.TellMePleaseTheValuesOfTheFields();//80,3
            //Console.WriteLine(calc.Divide(7, 0));//7
            //calc.TellMePleaseTheValuesOfTheFields();//7,0
            //Console.WriteLine(calc.Multiply());//7
            //calc.TellMePleaseTheValuesOfTheFields();//7,0
            //Console.WriteLine(calc.Multiply(10, 5));//50
            //calc.TellMePleaseTheValuesOfTheFields();//10,5




            //Test 4: overloaded constructor: default methods

            Calculator calc = new Calculator(-4, 5); // || x=-4 y=0
            Console.WriteLine("Test for overloaded constructor: default methods");


            calc.TellMePleaseTheValuesOfTheFields();//-4,5 || -4,0
            Console.WriteLine(calc.Add());//1 || -4
            calc.TellMePleaseTheValuesOfTheFields();//-4,5 ||-4,0 
            Console.WriteLine(calc.Subtract());//-9 || -4
            calc.TellMePleaseTheValuesOfTheFields();//-4,5 || -4,0
            Console.WriteLine(calc.Multiply());//-20 || 0
            calc.TellMePleaseTheValuesOfTheFields();//-4,5 || -4,0
            Console.WriteLine(calc.Divide());//0 || 4
            calc.TellMePleaseTheValuesOfTheFields();//-4,5 || -4,0


            Console.WriteLine("Test for overloaded constructor: overloaded methods");

            calc.TellMePleaseTheValuesOfTheFields();//-4,5
            Console.WriteLine(calc.Add(2, -3));//-1
            calc.TellMePleaseTheValuesOfTheFields();//2,-3
            Console.WriteLine(calc.Subtract(-4, 9));//-13
            calc.TellMePleaseTheValuesOfTheFields();//-4,9
            Console.WriteLine(calc.Multiply(-2, -5));//10
            calc.TellMePleaseTheValuesOfTheFields();//-2,-5
            Console.WriteLine(calc.Divide(4, 3));//1
            calc.TellMePleaseTheValuesOfTheFields();//4,3
            Console.WriteLine(calc.Divide(80, 3));//26
            calc.TellMePleaseTheValuesOfTheFields();//80,3
            Console.WriteLine(calc.Divide(7, 0));//7
            calc.TellMePleaseTheValuesOfTheFields();//7,0
            Console.WriteLine(calc.Divide(10, 5));//50
            calc.TellMePleaseTheValuesOfTheFields();//10,5

            // Test 3: overloaded constructor :default methods + overloaded methods:
            Console.WriteLine("Test for overloaded constructor: default methods + overloaded methodss");


            Console.WriteLine(calc.Subtract(-4, 9));//-13
            calc.TellMePleaseTheValuesOfTheFields();//-4,9
            Console.WriteLine(calc.Multiply(-2, -5));//10
            calc.TellMePleaseTheValuesOfTheFields();//-2,-5
            Console.WriteLine(calc.Divide(4, 3));//1
            calc.TellMePleaseTheValuesOfTheFields();//4,3
            Console.WriteLine(calc.Multiply());//12
            calc.TellMePleaseTheValuesOfTheFields();//4,3
            Console.WriteLine(calc.Add(-2, 3));// 1
            calc.TellMePleaseTheValuesOfTheFields();//-2,3
            Console.WriteLine(calc.Divide());//0
            calc.TellMePleaseTheValuesOfTheFields();//-2,3
            Console.WriteLine(calc.Divide(0, 3));//0
            calc.TellMePleaseTheValuesOfTheFields();//0,3
            Console.WriteLine(calc.Divide(7, 0));//7
            calc.TellMePleaseTheValuesOfTheFields();//7,0
            Console.WriteLine(calc.Multiply());//7
            calc.TellMePleaseTheValuesOfTheFields();//7,0
            Console.WriteLine(calc.Multiply(10, 5));//50
            calc.TellMePleaseTheValuesOfTheFields();//10,5
            Console.WriteLine(calc.Add(9, 0)); //9
            calc.TellMePleaseTheValuesOfTheFields();//9,0
            Console.WriteLine(calc.Multiply());//0
            calc.TellMePleaseTheValuesOfTheFields();//9,0
            Console.WriteLine(calc.Subtract(-15, 0)); //0
            calc.TellMePleaseTheValuesOfTheFields();//-15,0
            Console.WriteLine(calc.Divide());//-15
            calc.TellMePleaseTheValuesOfTheFields();//-15,0
            



        }
    }
}
