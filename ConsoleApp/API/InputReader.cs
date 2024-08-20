namespace ConsoleApp.API;

public static class InputReader
{
    public static bool ReadBool(string message)
    {
        Console.WriteLine(message);
        var input = Console.ReadLine().Trim().ToLower().First();
        while (input != 'y' && input != 'n')
        {
            Console.WriteLine(message);
            input = Console.ReadLine().Trim().ToLower().First();
        }
        return input == 'y';
    }

    public static string ReadString(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine().Trim();
    }

    public static int ReadInt(string message, int minValue, int maxValue)
    {
        int value;
        do
        {
            Console.WriteLine(message);
        } while (!int.TryParse(Console.ReadLine(), out value) || value < minValue || value > maxValue);
        return value;
    }

    public static double ReadDouble(string message, double minValue, double maxValue)
    {
        double value;
        do
        {
            Console.WriteLine(message);
        } while (!double.TryParse(Console.ReadLine().Replace(',', '.'), out value) || value < minValue || value > maxValue);
        return value;
    }
}