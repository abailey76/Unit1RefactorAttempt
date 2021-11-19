﻿using System;
using System.Collections.Generic;

namespace Unit1AssignmentRefactorAttempt
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome, " + userName + ". It's quiz time. Let's go!!\n");

            List<string> questionList = new List<string>
            {
                "Who was the first American woman in space?",
                "True or False: 5 kilometer == 5000 meters?",
                "(5+3)/2*10 = ?",
                "Given the array [8, 'Orbit', 'Trajectory, 45], what entry is at index 2?",
                "What is the minimum crew size for the ISS?"
            };

            List<string> quizAnswers = new List<string>
            {
                "Sally Ride",
                "true",
                "40",
                "Trajectory",
                "3"
            };

            List<string> userAnswers = new List<string>();

            

            for (int i=0; i <= 4; i++)
            {
                Console.WriteLine(questionList[i]);

                string input = Console.ReadLine();

                userAnswers.Add(input);

                Console.WriteLine("\nYou answered: {0}", userAnswers[i]);
                Console.WriteLine("\nCorrect Answer:  {0}\n", quizAnswers[i]);

            }

            foreach (string userAnswer in userAnswers)
            {
                Console.WriteLine(userAnswer);
            }

        }
    }
}
