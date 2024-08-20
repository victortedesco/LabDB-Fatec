using ConsoleApp.API;

namespace ConsoleApp.Exercises;

public class Ex2 : Ex
{
    public override void Execute()
    {
        var name = InputReader.ReadString("Escreva seu nome:");
        var currentYear = DateTime.Now.Year;
        var birthYear = InputReader.ReadInt("Escreva seu ano de nascimento:", int.MinValue, currentYear);

        var age = currentYear - birthYear;
        PrintResults(name, age);

        Console.ReadKey();
    }

    private static void PrintResults(string name, int age)
    {
        var days = age * 365;
        var hours = days * 24;
        var minutes = hours * 60;
        var heartBeats = minutes * 75;

        Console.WriteLine("\nRelatório:");
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine($"Idade: {age}");
        Console.WriteLine($"Quantidade de dias vividos são: {days}");
        Console.WriteLine($"Quantidade de horas vividas são: {hours}");
        Console.WriteLine($"Quantidade de minutos vividos são: {minutes}");
        Console.WriteLine($"Quantidade total de batimentos cardíacos são: {heartBeats}\n");
    }
}