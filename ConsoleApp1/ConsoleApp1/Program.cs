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

            do
            {
                Console.WriteLine("Please Choose From The Following Options");

                Console.WriteLine("Option 1: display the following 20 numbers in the sequence, and show odd numbers *4 and even *3");
                Console.WriteLine("Option 2: Provide a number and divide by 3, loops until you enter 'END'");
                Console.WriteLine("Option 3: Exit the Program");

                String userChoice = Console.ReadLine();
                int finalUserChoice = int.Parse(userChoice);

                if (finalUserChoice == 1)
                {
                    Option1();
                }
                else if (finalUserChoice == 2)
                {
                    Option2();
                }
                else if (finalUserChoice == 3)
                {
                    Console.WriteLine("Exiting!");
                    running = false;
                }
                else
                {
                    Console.WriteLine("Please Try Again!");
                }
            }while (running);
        }

        static int[] Return20Numbers(int userInput)
        {
            int[] numArray = new int[20];

            for (int i = userInput; i <= (userInput + 19); i++)
            {
                numArray[i] += i;
            }

            return numArray;
        }

            static void Option1()
            {
                // get user input
                int input = 0;

                Console.WriteLine("What number would you like to start with?");

                input = int.Parse(Console.ReadLine());

                // takes user input and prints the following 20 numbers in the sequence
                int[] numSequnce = new int[20];

                int[] oddNumbers = new int[10];
                int[] evenNumbers = new int[10];

                numSequnce = Return20Numbers(input);

                // multiply the odd numbers by 4 



                // multiply the even numbers by 3

                Console.WriteLine(numSequnce);
            }

            static void Option2()
            {
                bool looping = true;

                while (looping)
                {
                    try
                    {
                        //Get user input
                        Console.WriteLine("Please Enter The Number You Would like to divide by 3");

                        String numInput = Console.ReadLine(); 

                        if (numInput == "end" || numInput == "END")
                        {
                            looping = false;
                        }
                        else
                        {
                            int finalOutput = (int.Parse(numInput));

                            Console.WriteLine((finalOutput / 3));
                        }
                    }
                    catch
                    {
                        //Console.WriteLine(Exception e);
                    }
                }
            }
        }
    }