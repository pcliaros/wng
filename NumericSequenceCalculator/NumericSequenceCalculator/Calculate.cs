using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumericSequenceCalculator
{
    public class Calculate
    {
        public static int Number = 0;
        public static string Error = string.Empty;

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }

        public static bool CheckValidity(string enteredValue, int option)
        {
            // Check Inputs
            if (enteredValue == string.Empty)
            {
                Error = "<p style=\"color:red\">You must enter a whole, positive number.</p>";
                return false;
            }

            bool valid = int.TryParse(enteredValue, out Number);
            if (!valid)
            {
                Error = "<p style=\"color:red\">You must enter a whole, positive number.</p>";
                return false;
            }

            if (Number <= 0)
            {
                Error = "<p style=\"color:red\">You must enter a whole, positive number.</p>";
                return false;
            }

            if (option == 0)
            {
                Error = "<p style=\"color:red\">You must select the sequence you would like to calculate.</p>";
                return false;
            }

            return true;
        }

        public static string ReturnSequence(string enteredValue, int option)
        {
            if (!CheckValidity(enteredValue, option))
            {
                return Error;
            }

            string sequence = string.Empty;

            if (option == 1)
            {
                for (int i = 1; i <= Number; i++)
                {
                    sequence += "" + i + "; ";
                }
            }
            else if (option == 2)
            {
                for (int i = 1; i <= Number; i++)
                {
                    if (IsOdd(i))
                    {
                        sequence += "" + i + "; ";
                    }
                }
            }
            else if (option == 3)
            {
                for (int i = 1; i <= Number; i++)
                {
                    if (IsEven(i))
                    {
                        sequence += "" + i + "; ";
                    }
                }
            }
            else if (option == 4)
            {
                for (int i = 1; i <= Number; i++)
                {

                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        sequence += "Z; ";
                    }
                    else if (i % 3 == 0)
                    {
                        sequence += "C; ";
                    }
                    else if (i % 5 == 0)
                    {
                        sequence += "E; ";
                    }
                    else
                    {
                        sequence += "" + i + "; ";
                    }
                }
            }
            else if (option == 5)
            {
                int a = 0;
                int b = 1;

                for (int i = 0; a <= Number; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;

                    if (a <= Number)
                    {
                        sequence += "" + a + "; ";
                    }
                }
            }

            return "<p>" + sequence + "</p>";
        }
    }
}