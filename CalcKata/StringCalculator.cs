using System;
using System.Linq;

namespace CalcKata;
public class StringCalculator
{

    public int Add(string numbers)
    {
        var delimiters = new char[] { ',', '\n' };
        var splitInputs = numbers
            .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);

        return splitInputs.Sum();
    }

}
