using CreateLogo.Logos.Contracts;
using CreateLogo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateLogo.Logos
{
    public class MentorMateLogo : Logo, ILogo
    {

        private const string companyName = "Mentor Mate";
        
        public MentorMateLogo(int width)
            : base(companyName, width)
        {
        }


        public override char[,] CreateLogoMatrix()
        {
            int rowsNumber = Width + 1;
            int colsNumber = Width * 10;
            int singleLetterCols = Width * 5;

            char[,] matrix = new char[rowsNumber, colsNumber];

            for (int rows = 0; rows < rowsNumber; rows++)
            {

                for (int cols = 0; cols < colsNumber; cols++)
                {

                    if ((cols > Width - 1 - rows && cols <=  Width - 1 - rows + Width) //for first M
                        || (cols > Width - 1 - rows + singleLetterCols && cols <= Width - 1 - rows + Width + singleLetterCols)) //for second M
                    {
                        matrix[rows, cols] = '*';
                    }
                    else if (((cols > Width - 1 + rows && cols <= Width - 1 + rows + Width)) //for first M
                        || ((cols > Width - 1 + rows + singleLetterCols && cols <= Width - 1 + rows + Width + singleLetterCols))) //for second M
                    {

                        matrix[rows, cols] = '*';
                    }
                    else if (((cols > 3 * Width - 1 - rows && cols <= 3 * Width - 1 - rows + Width)) //for first M
                        || ((cols > 3 * Width - 1 - rows + singleLetterCols && cols <= 3 * Width - 1 - rows + Width + singleLetterCols))) //for second M
                    {

                        matrix[rows, cols] = '*';
                    }
                    else if (((cols > 3 * Width - 1 + rows && cols <= 3 * Width - 1 + rows + Width)) //for first M
                        || ((cols > 3 * Width - 1 + rows + singleLetterCols && cols <= 3 * Width - 1 + rows + Width + singleLetterCols))) //for second M
                    {

                        matrix[rows, cols] = '*';
                    }

                    else
                    {
                        matrix[rows, cols] = '-';
                    }
                }

            }
            return matrix;
        }
    }
}
