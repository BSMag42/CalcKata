using System;

namespace CalcKata;
public class StringCalculator
{
    public StringCalculator()
    {}

    public int Add(string param1, string param2)
    {
        var result = 0;
        if (param1 != "")
        {
            var int1 = int.Parse(param1);
            result += int1;
        }

        if (param2 != "")
        {
            var int2 = int.Parse(param2);
            result += int2;
        }
            
        return result;
    }

}
