﻿using System;


namespace SandBoxC
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] values = { null, "160519", "9432.0", "16,667", "  -322  ", "+4302", "(100)", "01FA" };
            foreach (var value in values)
            {
                int number;

                bool result = Int32.TryParse(value, out number);
                if (result)
                {
                    Console.WriteLine("Converted '{0}' to {1}.", value, number);
                }
                else
                {
                    //if (value == null) value = "";
                    Console.WriteLine("Attempted conversion of '{0}' failed.", value == null ? "<null>" : value);
                }
    }
}
