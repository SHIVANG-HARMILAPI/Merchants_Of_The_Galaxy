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
}
