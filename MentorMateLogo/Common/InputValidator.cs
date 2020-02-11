using System;
namespace CreateLogo.Common
{
    public static class InputValidator
    {
        public static void CheckIfInputIsCorrect(int number)
        {
            if (number < Constants.MinimumWidth || number > Constants.MaximumWidth || number % 2 == 0)
            {
                throw new InvalidOperationException(ErrorMessages.InvalidInput);
            }
        }
    }
}
