/*
* Luke Kingdon and Jordan Hamilton Assignment 2
*Name of Project: A3LKJHP1
*Assignment: Part 1 of assignment 3
*Revision History; 
*       Created 14/10/2022
*
*
*Purpose  You are creating a console-based program that allows the user to view a list of
numbers and do a few calculations. This program will be shown as a menu with
three (3) options. The menu should be created with a do loop. Make sure the
user knows what they are to type.

Option 1
The first option is to display a list of 20 numbers starting at a number the user
specifies; when the option is selected – first thing is to ask the user for the
starting number.
After the user provides this input, all the values should be displayed at once as
follows:
 User a for loop to increment through the numbers (beginning with the
starting number)
For each number: multiply the even ones by 3 and multiply the odd
numbers by 4.

Option 2
This option should be created using a while loop. It must display the result of
any number the user provides divided by 3. The option should begin by asking
the user for a number. – the program should then display the result of that
number divided by 3.
This process should be repeated until the user types “END” to return to the
original menu.
Further explanation
If the user enters a number, then the result of the number the user enters
divided by 3 must be printed to the screen. The user will then be asked for
input again. This continues until the user wishes to end the sequence by
entering “END”.

Option 3
The third option is to exit the program.
Any invalid option entered by the user should prompt the menu to reappear
and ask the same three options.
Any string entry by the user, in place of the expected numeric value should
not crash the program.
You must use the appropriate loop for each segment as stated for each
question
Your program must:
a. Encapsulate the logic of options 1 and 2 each within their own Method.
b. The functionality of the menu is correct as described.
c. Proper error handling.
d. Adhere to coding standards as described by the course. Marks will be
taken off wherever coding standards are not followed.
e. Make sure it is very clear on what the User is to enter.

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A3LKJHP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Please Choose From The Following Options");

                Console.WriteLine("Option 1: display the following 20 numbers in the sequence, and show odd numbers *4 and even *3");
                Console.WriteLine("Option 2: Provide a number and divide by 3, loops until you enter 'END'");
                Console.WriteLine("Option 3: Exit the Program");

                try
                {
                    String userInput = Console.ReadLine();
                    int userChoice = int.Parse(userInput);

                    if (userChoice == 1)
                    {
                        Option1();
                    }
                    else if (userChoice == 2)
                    {
                        Option2();
                    }
                    else if (userChoice == 3)
                    {
                        Console.WriteLine("Exiting!");
                        running = false;
                    }
                    else
                    {
                        Console.WriteLine("Please Try Again!");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("That is not the correct input type!");
                }
            }
        }

        public static int[] Return20Numbers(int userInput)
        {
            int[] numArray = new int[20];

            for (int i = 0; i <= 19; i++)
            {
                numArray[i] = (userInput + i);
            }
            return numArray;
        }

        public static void Option1()
        {
            int[] numSequnce = new int[20];

            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();

            // get user input
            Console.WriteLine("What number would you like to start with?");

            int input = int.Parse(Console.ReadLine());


            // sets numSequence to the return value of Return20Numbers with the user input passed in
            numSequnce = Return20Numbers(input);

            // Sorts the odd and even numbers and put them into their own arrays

            for (int i = 0; i <= numSequnce.Length - 1; i++)
            {
                if ((numSequnce[i] % 2) == 0)
                {
                    evenNumbers.Add(numSequnce[i]);
                }
                else
                {
                    oddNumbers.Add(numSequnce[i]);
                }
            }


            // multiply the odd numbers by 4 
            for (int i = 0; i <= (oddNumbers.Count - 1); i++)
            {
                oddNumbers[i] = (oddNumbers[i] * 4);
            }

            // multiply the even numbers by 3
            for (int i = 0; i <= (evenNumbers.Count - 1); i++)
            {
                evenNumbers[i] = (evenNumbers[i] * 3);

            }

            // displaying the information in an understandable way
            Console.WriteLine("The Sequence of Numbers that Resulted From Your Input is:");
            for (int i = 0; i <= numSequnce.Length - 1; i++)
            {
                Console.WriteLine(numSequnce[i]);
            }

            Console.WriteLine("The Even Number Array is:");
            for (int i = 0; i <= evenNumbers.Count - 1; i++)
            {
                Console.WriteLine(evenNumbers[i]);
            }

            Console.WriteLine("The Odd Number Array is:");

            for (int i = 0; i <= oddNumbers.Count - 1; i++)
            {
                Console.WriteLine(oddNumbers[i]);
            }
        }

        public static void Option2()
        {
            bool looping = true;

            while (looping)
            {
                try
                {
                    //Get user input
                    Console.WriteLine("Please Enter The Number You Would like to divide by 3");

                    String userInput = Console.ReadLine();

                    if (userInput == "end" || userInput == "END")
                    {
                        looping = false;
                    }
                    else
                    {
                        int finalOutput = (int.Parse(userInput));

                        Console.WriteLine((finalOutput / 3));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("That is not the correct input /n");
                }
            }
        }
    }
}
