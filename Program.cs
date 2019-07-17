using System;
using System.Collections.Generic;


namespace CalculatingAverage
{
    class Program
    {
        static void Basic_sum()
        {
            int[] sumArray = new int[10];
            int i;
            Console.WriteLine("Enter 10 intergers between 1 and 100");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("element - {0} is ", i + 1);
                sumArray[i] = int.Parse(Console.ReadLine());

            }

            int sum = 0;
            for (i = 0; i < sumArray.Length; i++)
            {
                sum += sumArray[i];
            }
            Console.WriteLine($"The sum of the input numbers is {sum}");
            Console.WriteLine($"Average of the input is {sum / 10}");


        }

        static void KnownScores()
        {
            //Enter number of test scores
            Console.WriteLine("Enter number of test scores graded");
            int testsGraded = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n The number of tests that were graded is {testsGraded}");
            //set array to a variable 
            int[] testAverage = new int[testsGraded];
            int i;
            //For statement 
            for (i = 0; i < testsGraded; i++)
            {
                Console.WriteLine("Test {0} score is:", i + 1);
                testAverage[i] = int.Parse(Console.ReadLine());
            }
            int sumTest = 0;
            for (i = 0; i < testAverage.Length; i++)
            {
                sumTest += testAverage[i];
            }
            int averageTest = (sumTest / testsGraded);
            Console.WriteLine($"\nThe average score for all the tests is {averageTest}");
            //divide final score by 10, to give 1 interger
            int singleScore = averageTest / 10;

            //Set the letter values of the average (100-90 = A etc.)
            switch (singleScore)
            {
                case 10:
                    Console.WriteLine("The Letter Grade is : A+");
                    break;
                case 9:
                    Console.WriteLine("The Letter Grade is : A");
                    break;
                case 8:
                    Console.WriteLine("The Letter Grade is : B");
                    break;
                case 7:
                    Console.WriteLine("The Letter Grade is : C");
                    break;
                case 6:
                    Console.WriteLine("The Letter Grade is : D");
                    break;
                default:
                    Console.WriteLine("The Letter Grade is : F");
                    break;
                        
            }
        }

        static void UnknownScores()
        {

            Console.WriteLine("Enter all test scores one line at a time");
            //Setting up list with type string 
            //List<string> = new List<string>(); is the command to make a list
            List<string> testInput = new List<string>();
            //
            Console.WriteLine("\nEnter test score and press ENTER");

            //User Input defined as a string
            string userInput = Console.ReadLine();


            //This is the While loop, it states: While the userInput is not null or empty, 
            //add the userInput add the user input to the list with the xs.Add() command

            while (!string.IsNullOrEmpty(userInput))
            {
                testInput.Add(userInput);
                Console.WriteLine("\nEnter next test score and press ENTER");
                userInput = Console.ReadLine();

                //The If statement is just here to tell the user how many inputs they have entered, 
                //it will exit the application if no scores are entered
                if (testInput.Count > 0)
                {
                    Console.WriteLine($"You have entered {testInput.Count + 1} test scores");
                    //prints the current list count + 1 for easy user understanding
                }
                else
                {
                    Console.WriteLine("No scores were entered");
                    Environment.Exit(0);
                }

            }
            //Converting a string list to an int list with the xs.ConverAll(int.Parse) command
            List<int> intTestInput = testInput.ConvertAll(int.Parse);

            int sumTestScores = 0; //defining new int sum value as 0 so it can be added too
            foreach (int input in intTestInput) //states for each value used in the newly converted int List, add that to the sum
            {
                sumTestScores += input;

            }
            Console.WriteLine($"\n The sum of all test scores is {sumTestScores}");
            //THANK THE INTERNET OVERLORDS FOR HELPING ME LEARN ALL THIS; AND ELLIOT OF COURSE
            int averageOutput = sumTestScores / intTestInput.Count;
            Console.WriteLine($"\n The average test score is {averageOutput}");
            int letterGrade = averageOutput / 10;

            switch (letterGrade)
            {
                case 10:
                    Console.WriteLine("The Letter Grade is : A+");
                    break;
                case 9:
                    Console.WriteLine("The Letter Grade is : A");
                    break;
                case 8:
                    Console.WriteLine("The Letter Grade is : B");
                    break;
                case 7:
                    Console.WriteLine("The Letter Grade is : C");
                    break;
                case 6:
                    Console.WriteLine("The Letter Grade is : D");
                    break;
                default:
                    Console.WriteLine("The Letter Grade is : F");
                    break;
            }



        }

        static void Main(string[] args)
        {
            //Basic averaging of numbers
            Basic_sum();
            //Inputing how many tests will be graded
            KnownScores();
            //Inputting just scores and it will build a list/array
            UnknownScores();


        } 

    }
}
