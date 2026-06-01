using System.Text;

namespace project.Core;

public class RomanConverter
{

    new Dictionary<int, string> keyValuePairs = new Dictionary<int, string>
    {
        {1000, "M"},
        {900, "CM"}, 
        {500, "D"}, 
        {400, "CD"}, 
        {100, "C"},  
        {90, "XC"},  
        {50, "L"},  
        {40, "XL"},
        {10, "X"},
        {9, "IX"},
        {5, "V"},
        {4, "IV"},
        {1, "I"}
    };
    public string ConvertToRoman(int number)
    {
        if (number <= 0 || number > 3999)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Input must be between 1 and 3999.");
        }

        var romanNumber = new StringBuilder();

        foreach (var par in keyValuePairs)
        {
            while (number >= par.Key)
            {
                romanNumber.Append(par.Value);
                number -= par.Key;
            }
        }

        return romanNumber.ToString();

        throw new NotImplementedException();
    }

    public int ConvertToInteger(string roman)
    {
        if(roman == "I")
        {
            return 1;
        }
       
        if(roman == "IV"){
            return 4;
        }

        if(roman == "X")
        {
            return 10;
        }


        throw new NotImplementedException();
    }
    
}
