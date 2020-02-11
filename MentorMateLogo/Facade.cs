using CreateLogo.Common;
using CreateLogo.Logos;
using CreateLogo.Logos.Contracts;

using System;
using System.Collections.Generic;
using System.Text;

namespace CreateLogo
{
    public static class Facade
    {
        public static void Start()
        {
            Console.WriteLine(OutputMessages.WelcomeMessage);
            Console.WriteLine(OutputMessages.InstructionMessage);

            while (true)
            {
                try
                {
                    Console.WriteLine(OutputMessages.InputNMessage);

                    int n = int.Parse(Console.ReadLine());

                    InputValidator.CheckIfInputIsCorrect(n);

                    ILogo mentorMateLogo = new MentorMateLogo(n);

                    //char[,] matrix = CreateMatrix(mentorMateLogo.Width);

                    PrintMatrix(mentorMateLogo.CreateLogoMatrix());

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();

            }
        }
    }
}
