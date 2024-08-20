using ConsoleApp.API;

namespace ConsoleApp.Exercises;

public class Ex3 : Ex
{
    public override void Execute()
    {
        var name = InputReader.ReadString("Digite seu nome");
        var scores = new double[4];
        ReadScoresInput(scores);
        var frequency = InputReader.ReadInt("Digite a frequência:", 0, 100);
        var average = scores.Average();

        PrintResult(name, frequency, average);

        Console.ReadKey();
    }

    private static void ReadScoresInput(double[] scores)
    {
        for (var i = 0; i < scores.Length; i++)
        {
            scores[i] = InputReader.ReadDouble($"Digite a nota {i + 1}: ", 0, 10);
        }
    }

    private static void PrintResult(string name, int frequency, double average)
    {
        Console.WriteLine("\nRelatório:");
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine($"Média: {average % .2f}");
        Console.WriteLine($"Frequência: {frequency}%");

        var result = frequency >= 75 && average >= 6 ? "Aprovado" : "Reprovado";

        Console.WriteLine($"Resultado: {result}\n");
    }
}