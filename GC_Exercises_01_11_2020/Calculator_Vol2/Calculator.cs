using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Vol2
{
    class Calculator
    {
        /*
           * constr        values (x,y)     methods   result(add)   result(divide)
           * A ()           0,0              ()       A1 0 + 0       A2 0 / (1)
           * B ()           0,0              (x, y)   B1 x + y       B2 x / (y = 1)
           * C (x, y)       x,y              ()       B1 x + y       B2 x / (y = 1)
           * D (x, y)       x,y              (i,j)    D1 i + j       D2 i / (j = 1)
           * E (x, y == 0)  x,y              ()       B1 x + y       B2 x / (y = 1)  
           *
           * 1st case = A1  Result of Method
           * 2st case = A2 Result of division
           * 3nd case = B1 Result of Method
           * 4th case = B2 result of division
           * 5th case = D1 Result of Method
           * 6th case = D2 result of division

     */


        //These two fields are set public only for test purposes
        //they should be private and exposed only via methods (or properties)

        public int x;
        public int y;



        public Calculator()
        {

        }

        public Calculator(int x, int y)
        {
            Calculate(x, y, '?');

        }

        public double Add()
        {
            return (Calculate(x, y, '+'));
        }

        public double Subtract()
        {
            return (Calculate(x, y, '-'));
        }

        public double Multiply()
        {
            return (Calculate(x, y, '*'));
        }

        public double Divide()
        {
            return (Calculate(x, y, '/'));
        }
        //overloaded
        public double Add(int x, int y)
        {

            return (Calculate(x, y, '+'));
        }

        public double Subtract(int x, int y)
        {
            return (Calculate(x, y, '-'));
        }

        public double Multiply(int x, int y)
        {

            return (Calculate(x, y, '*'));
        }

        public double Divide(int x, int y)
        {
            return (Calculate(x, y, '/'));
        }

        //private methods

        private double Calculate(int x, int y, char oper)
        {
            //bool divByZero;
            //int result = 0;
            //switch (calculation)  //I believe there are more advanced/elegant ways to deal with this switch
            //{                     // but I don't know them yet 
            //    case '+':
            //        divByZero = AssignFieldValue(x, y, false);
            //        result = (this.x + this.y);
            //        RevertFieldValue(x, y, false, divByZero);
            //        break;
            //    case '-':
            //        divByZero = AssignFieldValue(x, y, false);
            //        result = (this.x - this.y);
            //        RevertFieldValue(x, y, false, divByZero);
            //        break;
            //    case '*':
            //        divByZero = AssignFieldValue(x, y, false);
            //        result = (this.x * this.y);
            //        RevertFieldValue(x, y, false, divByZero);
            //        break;
            //    case '/':
            //        divByZero = AssignFieldValue(x, y, true);//boolean needs to be stored here
            //        result = (this.x / this.y);
            //        RevertFieldValue(x, y, true, divByZero);//Cannot call directly AssignFieldValue(x, y, false) 
            //        break;                                  //because it will reassign to 0 if  I divide by zero          
            //    default:
            //        divByZero = AssignFieldValue(x, y, false);
            //        result = 0;
            //        RevertFieldValue(x, y, false, divByZero);
            //        break;
            //}


            double result;
            switch (oper) //searched for another way
            {
                case '+':
                    result = Operation('+', false, x, y);
                    break;
                case '-':
                    result = Operation('-', false, x, y);
                    break;
                case '*':
                    result = Operation('*', false, x, y);
                    break;
                case '/':
                    result = Operation('/', true, x, y);
                    break;
                default:
                    result = Operation('?', false, x, y);
                    break;
            }


            return result;
        }


        //Assign field values to x, y
        //check operation, if division set y=1 then assign, 
        //perform operation
        //if division by 0 occured set y=0 and reassign x,y
        //return result
        private double Operation(char oper, bool isDivision, int x, int y)
        {
            bool divByZero = AssignFieldValue(x, y, isDivision);
            double result = Operations(oper, this.x, this.y);
            RevertFieldValue(x, y, divByZero);
            return result;
        }



        //private bool AssignFieldValue(int x, int y, bool isDivision)
        //ASSIGNS x and y to x and y of class instant IF [   (operation is addition)
        //                                              OR   (operation is subtraction) 
        //                                              OR   (operation is multiplication)
        //                                              OR { (operation is division) AND (y neq 0) } ]
        //ASSIGNS x and 1 to x and y of class instant if [   (operation is division) AND (y eq 0)    ]
        //so that the program does not crash
        //RETURNS TRUE IF [ (operation is division) AND (y eq 0) ],  FALSE otherwise.
        private bool AssignFieldValue(int x, int y, bool isDivision)
        {
            bool divByZero = false;
            this.x = x;
            if (y == 0 && isDivision)
            {
                this.y = 1;
                divByZero = true;
            }
            else
            {
                this.y = y;
            }
            return divByZero;

        }


        // private void RevertFieldValue(int x, int y, bool DivByZero)
        //always called after AssignFieldValue
        //REASSIGNS x and 0 to x and y IF AND ONLY IF Division By Zero took place
        //To avoid unexpected results in operations after divisions by zero.
        private void RevertFieldValue(int x, int y, bool DivByZero)
        {
            if (DivByZero == true)
            {
                this.x = x;
                this.y = 0;
            }

        }

        //key value representation of operators and operations: very useful
        //The sorry S.O.B doesn't allow the possibility of y=0 because it thinks I will divide by zero
        //It throws exception for all operations. It needs to hold integers not NaN for every possible Key-value pairs 
        //or else it will not define the particular dictionary
        //I understand that I need a key value pair, but i pass the values parametrically (value(x,y)) so I must ensure
        //that this particular "container" of such pairs yields the correct value type (int) for all input parameters (x,y)
        //If I do [1] no problem arises

        //It doesn't matter if I have accounted for division by zero in AssignFieldValue()
        //This has more to do with the particular parametrical definition of the Dictionary in this case. (I think.) 

        private double Operations(char oper, double x, double y)
        {
            Dictionary<char, double> operations = new Dictionary<char, double>
            {
                {'+', (x + y)},  //(x+y)=always an int for all ints x,y
                {'-', (x - y)}, //(x-y)=always an int for all ints x,y
                {'*', (x * y) },//(x*y)=always an int for all ints x,y
                {'/', (x / (y==0? 1: y)) }, // [1] (x / (y==0? 1: y))=always an int for all ints x,y 
                //                            If these conditions are not met I cannot define this dictionary for {operator, [x,0]}          
                {'?',0 } //int 0
            };

            return operations[oper];
        }



        public void TellMePleaseTheValuesOfTheFields()
        {
            Console.WriteLine($"x={x}, y={y}");
        }

    }
}
