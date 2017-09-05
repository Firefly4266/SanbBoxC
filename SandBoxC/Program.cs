using System;


namespace SandBoxC
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int convertedNumber;
            // convert input to number
            //int.TryParse(input, out convertedNumber);

            bool isConvertedSuccessfully = int.TryParse(input, out convertedNumber);

            if (!isConvertedSuccessfully)
            {
                throw new Exception("Conversion was not successful.");
            }
        }
    }
}
