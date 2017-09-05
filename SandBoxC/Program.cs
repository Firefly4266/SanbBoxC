using System;


namespace SandBoxC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
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
            }catch (Exception ex) {
                Console.WriteLine("There was an error {0}", ex.Message);
            }
            Console.WriteLine("The rest of my application is still running.");
        }
    }
}
