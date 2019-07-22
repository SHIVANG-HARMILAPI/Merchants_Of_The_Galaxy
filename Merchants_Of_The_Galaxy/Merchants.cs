using System;
using System.Collections.Generic;
using System.Collections;
namespace Merchants_Of_The_Galaxy
{
    public class Merchants
    {
        Dictionary<string, string> _assignRomanToVariable = new Dictionary<string, string>();
        public string AssignRomanNumberToVariable(string variable)
        {
            string[] vararray = variable.Split(' ');
            
            
            if (!_assignRomanToVariable.ContainsKey(vararray[0]))
            {
                _assignRomanToVariable.Add(vararray[0], vararray[2]);
            }
            return _assignRomanToVariable[vararray[0]];
        }
    }

    public class RomanToNumeralConvertor
    {
        public enum basicRomanValues{
            I=1,
            V=5,
            X=10,
            L=50,
            C=100,
            D=500,
            M=1000

        }
        public string Convert(string roman)
        {
            roman = roman.ToUpper();
            char ch = roman[0];
            bool checkException = ValidRomanNumberCheck(roman);
            if (!checkException)
            {
                return "Invalid Format";
            }
            int sum = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i != roman.Length - 1)
                {
                    if (int.Parse(GetNumeral(roman[i])) < int.Parse(GetNumeral(roman[i + 1])))
                    {
                        sum = sum + (int.Parse(GetNumeral(roman[i + 1])) - int.Parse(GetNumeral(roman[i])));
                        i++;
                    }
                    else
                    {
                        sum = sum + int.Parse(GetNumeral(roman[i]));
                    }
                }
                else
                {
                    sum = sum + int.Parse(GetNumeral(roman[i]));
                }
            }
            return sum.ToString();
        }

       public bool ValidRomanNumberCheck(string roman)
        {
            
            if (roman.Contains("IC") || roman.Contains("IL") || roman.Contains("ID") || roman.Contains("IM"))
            {
                return false;
            }
            if (roman.Contains("XM") || roman.Contains("XD"))
            {
                return false;
            }
            if (roman.Contains("VM") || roman.Contains("LM") || roman.Contains("DM") || roman.Contains("VX"))
            {
                return false;
            }
            if (roman.Contains("IIII") || roman.Contains("XXXX") || roman.Contains("CCCC") || roman.Contains("MMMM"))
            {
                return false;
            }
            if (roman.Contains("DD") || roman.Contains("LL") || roman.Contains("VV"))
            {
                return false;
            }
            return true;
        }
        public string GetNumeral(char roman)
        {
            string numeral = "";
            int number = 0;
            switch (roman)
            {
                case 'I':number = (int)basicRomanValues.I;
                    break;
                case 'V':
                    number = (int)basicRomanValues.V;
                    break;
                case 'X':
                    number = (int)basicRomanValues.X;
                    break;
                case 'L':
                    number = (int)basicRomanValues.L;
                    break;
                case 'C':
                    number = (int)basicRomanValues.C;
                    break;
                case 'D':
                    number = (int)basicRomanValues.D;
                    break;
                case 'M':
                    number = (int)basicRomanValues.M;
                    break;
                default:
                    number=0;
                    break;
            }
            numeral = number.ToString();
            return numeral;
        }
    }

}
