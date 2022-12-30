using System;
using System.Linq;

namespace CalcKata;
public class StringCalculator
{

    public int Add(string numbers)
    {
        var splitInputs = numbers.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);

        return splitInputs.Sum();
    }

}
