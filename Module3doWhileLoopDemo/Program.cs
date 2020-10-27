using System;
using static System.Console;

//Name: James Shoemaker
//Date: 04/04/2020
//Program Description: Module 3 do while looop

namespace Module3doWhileLoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Grading Application - Requests 5 grades and then calculates the average
            int grade = 0;
            double total = 0;
            double average = 0.0;
            int counter = 0;

            //for indefinite you have to get the control value outside of the loop for a while loop
            Write(" Please enter a grade as an integer - enter -1 to quit: ");
            grade = int.Parse(ReadLine());

            //in a do while use it when you must run the body of the code at least once
            do
            {


                total = total + grade;

                counter++;

                Write(" Please enter a grade as an integer - enter -1 to quit: ");
                grade = int.Parse(ReadLine());
            }

            while (grade != -1);

            average = total / counter;
            WriteLine($"You entered {counter} grades!");
            WriteLine($"the average grade is: {average.ToString("F1")}");
        }
    }
}
