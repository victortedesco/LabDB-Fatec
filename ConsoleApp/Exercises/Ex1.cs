using ConsoleApp.API;

namespace ConsoleApp.Exercises;

public class Ex1 : Ex
{
    public override void Execute()
    {
        var n1 = InputReader.ReadDouble("Informe um número:", double.MinValue, double.MaxValue);
        var n2 = InputReader.ReadDouble("Informe outro número:", double.MinValue, double.MaxValue);

        PrintResult(n1, n2);

        Console.ReadKey();
    }

    private static void PrintResult(double n1, double n2)
    {
        var sum = n1 + n2;
        var subtraction = n1 - n2;
        var multiplication = n1 * n2;
        var division = n1 / n2;

        Console.WriteLine("\nRelatório");
        Console.WriteLine($"A soma é: {sum} ");
        Console.WriteLine($"A subtração é: {subtraction} ");
        Console.WriteLine($"A multiplicação é: {multiplication} ");
        Console.WriteLine($"A divisão é: {division}\n");
    }
}