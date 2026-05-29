using System.Text;

namespace project.Core;

public class RomanConverter
{

    new Dictionary<int, string> keyValuePairs = new Dictionary<int, string>
    {
        {10, "X"},
        {9, "IX"},
        {5, "V"},
        {4, "IV"},
        {1, "I"}
    };
    public string ConvertToRoman(int number)
    {
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
}
