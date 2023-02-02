/*
 * Author: Michael Perez Chavira
 * Course: COMP003A-l01
 * Purpose: Lecture Activity 3
 */

namespace COMP003A.LectureActivity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("conditional (selection) statements");
            Console.WriteLine("****************************************");
            /************************************************************/

            Console.WriteLine("1. single if statement");
            Console.Write("\tEnter a whole positive number");
            int inputNumber = Convert.ToInt32(Console.ReadLine()); // user input as an integer

            // single if statement
            if(inputNumber % 2 == 0) 
            {
                // this code block executes if the condition about is true
                Console.WriteLine("\tinputNumber is even.");
            }

            /**************************************************************/
            Console.WriteLine("2. if-else statement");
            // if statement
            if (inputNumber % 2 == 0) 
            {
                // this code block executes if the condition is true
                Console.WriteLine("\tinputNumber is even.");
            }
            else
            {
                // this code block executes if the condition about is true
                Console.WriteLine("\tinputNumber is odd.");
            }

            /*************************************************************/
            Console.WriteLine("3. nested if statement");
            // nested if statement
            if (inputNumber % 2==0)
            {
                // this code block executes if inputNumber is divisible by 2
                Console.WriteLine("\tinputNumber is even.");

                if (inputNumber % 5 ==0)
                {
                    // this code block executes if inputNumber is
                    // divisible by 2 first, NOT divivisble by 5 after
                    Console.WriteLine("\t\tinputNumber is also divisbile by 5.");
                }
                else
                {
                    // this code block executes if inputNumber is
                    // didivisble by 2 first, NOTdivisble by 5 after
                    Console.WriteLine("\t\tinputNumber is NOT divisbile by 5.");
                }
            }
            else
            {
                //this code block executes if inputNumber is NOT divisble by 2
                Console.WriteLine("\tinputNumber is odd.");
            }

            /****************************************************************/

            Console.WriteLine("4. Multiple if-else statments");
            // multiple if-else statments
            if (inputNumber % 2 ==0) 
            {
                // this code blockexexcutes if the above condition is true 
                //the rest of the conditions will no longer execute
                Console.WriteLine("\tinputNumber is divisbile by 2.");
            }
            else if (inputNumber % 3 == 0)
            {
                // this code block executes if the above condition is true 
                // the rest of the conditions will no longer execute
                Console.WriteLine("tinputNumber is divisible by 3.");
            }
            else if (inputNumber % 5== 0 )
            {
                // this code block exexcutes if the above condition is true 
                // the rest of the conditions will no longer execute
                Console.WriteLine("\tinputNumber is divisble by 5.");
            }
            else if (inputNumber % 7 == 0)
            {
                // this code block exexcutes if the above condition is true 
                // the rest of the conditions will no longer execute
                Console.WriteLine("\tinputNumber is divisble by 7.");
            }
            else
            {
                // this code block exexcutes if the above conditions are NOT true
                Console.WriteLine("\tinputNumber is NOT divisible by 2/3/5/7.");
            }

            /********************************************************************/

            Console.WriteLine("5. ternary operator");
            string outputMessage = inputNumber % 2 == 0
                ? "\tinputNumber is even."
                : "tinputNumber is odd.";
            Console.WriteLine(outputMessage);   

            /*********************************************************************/

            int randomNumber = new Random() .Next(10); // generates a random number 10 or below
            Console.WriteLine("6. comparison operators");
            Console.WriteLine($"\t{inputNumber} == {randomNumber}: {inputNumber == randomNumber}");
            Console.WriteLine($"\t{inputNumber} != {randomNumber}: {inputNumber != randomNumber}");
            Console.WriteLine($"\t{inputNumber} > {randomNumber}: {inputNumber > randomNumber}");
            Console.WriteLine($"\t{inputNumber} >= {randomNumber}: {inputNumber >= randomNumber}");
            Console.WriteLine($"\t{inputNumber} < {randomNumber}: {inputNumber < randomNumber}");
            Console.WriteLine($"\t{inputNumber} <= {randomNumber}: {inputNumber <= randomNumber}");

            /*********************************************************************************/

            Console.WriteLine("7. logical operators");
            Console.WriteLine($"\t{inputNumber} == {randomNumber} && {inputNumber} >= {randomNumber}: " + $"{inputNumber == randomNumber && inputNumber >= randomNumber}");
            Console.WriteLine($"\t{inputNumber} == {randomNumber} || {inputNumber} >= {randomNumber}: " + $"{inputNumber == randomNumber || inputNumber >= randomNumber}");
            Console.WriteLine($"\t!(true) : {!(true)}");

            /********************************************************************************************/

            Console.WriteLine("8. switch statement");
            // switch statement
            switch (inputNumber)
            {
                case 2:
                    // this code block executes if the case condition is true
                    Console.WriteLine("\tinputNumber is divisble by 2.");
                    break;
                case 3:
                    // this code block executes if the case condition is true
                    Console.WriteLine("\tinputNumber is divisible by 3.");
                    break;  
                case 5:
                    // this code block executes if the case condition is true
                    Console.WriteLine("\tinputNumber is divisble by 5.");
                    break;
                case 7:
                    // this code block executes if the case condition is true
                    Console.WriteLine("\tinputNumber is divisible by 7.");
                    break;
                default:
                    // this code block executes if none of the cases above is true
                    Console.WriteLine("\tinputNumber is NOT divisible by 2/3/5/7.");
                    break;
            }



        }

        
    }
}