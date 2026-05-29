namespace project.Core;

public class RomanConverter
{
    public string ConvertToRoman(int number)
    {

        if (number == 1)
        {
            return "I";
        }
        if (number == 3)
        {
            return "III";
        }
        if (number == 4)
        {
            return "IV";
        }


        throw new NotImplementedException();
    }
}
