using System;
using System.Linq;

namespace CalcKata;
public class StringCalculator
{

    public int Add(string numbers)
    {
        var delimiters = new List<char> { ',', '\n' };

        if (numbers.StartsWith("//"))
        {
            var splitOnNewLineNumbers = numbers.Split(new char[]{'\n'}, 2);
            var customDelimiter = numbers.Substring(2, 1);
            char[] charDelimiter = customDelimiter.ToCharArray();
            delimiters.Add(charDelimiter[0]);
            numbers = splitOnNewLineNumbers[1];
        }
        
        var splitInputs = numbers
            .Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);

        return splitInputs.Sum();
    }

}
