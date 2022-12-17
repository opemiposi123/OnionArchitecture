namespace Shared.Application.Helper;

public static class Helper
{
    public static string GenerateCode()
    {
        Random rnd = new Random();
        string a;
        string b = "SCH-";
        for (int j = 0; j < 1; j++)
        {
            a = rnd.Next().ToString();
            b = $"{a.Substring(0, 5)}".ToString();

        }
        return b;
    }

}

