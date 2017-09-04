using System;


namespace SandBoxC
{
    class Program
    {
        static void Main(string[] args)
        {
            string someText = "Here is some Text.";
            string someOtherText = "Here is some text.";

            //using the OrdinalIgnoreCase version of Ordinal makes comparison case insensitive.
            bool isEqual = someText.Equals(someOtherText, StringComparison.OrdinalIgnoreCase);
            string addedText = (someText + " " + someOtherText + " " + "here is some more text.");
            string formattedString = String.Format("{0} {1} here is some more text.", someText, someOtherText);
            Console.WriteLine(addedText);
            Console.WriteLine(formattedString);

            Console.WriteLine(someText.Length);
            Console.WriteLine(someText[8]);

            Console.WriteLine(someText.Substring(8, 4));

            Console.WriteLine(someText.ToLower());
            Console.WriteLine(someText.ToUpper());

            string anotherText = string.Empty;
            //this is what should be used instead of---  string anotherText = "";

            string replacedText = someText.Replace("Text", "String");
            Console.WriteLine(replacedText);
        }
    }
}
