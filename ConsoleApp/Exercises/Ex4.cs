using ConsoleApp.API;
using Color = ConsoleApp.API.ConsoleColors;

namespace ConsoleApp.Exercises;

public class Ex4 : Ex
{
    public override void Execute()
    {
        int input;
        do
        {
            PrintMenu();
            input = InputReader.ReadInt("Opção", 1, 4);
            GetOption(input);

            if (input != 4)
                Console.ReadKey();

            Console.Clear();
        } while (input != 4);
    }

    private static void PrintMenu()
    {
        Console.WriteLine("Calculadora Multifuncional");
        Console.WriteLine("Escolha uma das opcões abaixo:");
        Console.WriteLine($"{Color.RED}1. {Color.NORMAL}Operações Aritméticas");
        Console.WriteLine($"{Color.RED}2. {Color.NORMAL}Cálculo de Média");
        Console.WriteLine($"{Color.RED}3. {Color.NORMAL}Classificação de Triângulo");
        Console.WriteLine($"{Color.RED}4. {Color.NORMAL}Sair\n");
    }

    private static void GetOption(int input)
    {
        switch (input)
        {
            case 1:
                RunAritmeticOperations();
                break;
            case 2:
                RunAverageScore();
                break;
            case 3:
                RunTriangleClassification();
                break;
        }
    }

    private static void RunAritmeticOperations()
    {
        var n1 = InputReader.ReadDouble($"Digite N1:", double.MinValue, double.MaxValue);
        var n2 = InputReader.ReadDouble($"Digite N2:", double.MinValue, double.MaxValue);

        Console.WriteLine($"\nRelatório:");
        Console.WriteLine($"Soma: {n1 + n2}");
        Console.WriteLine($"Subtração: {n1 - n2}");
        Console.WriteLine($"Multiplicação: {n1 * n2}");

        if (n2 != 0)
            Console.WriteLine($"Divisão: {n1 / n2}");

        Console.WriteLine($"Módulo: {n1 % n2}");
    }

    private static void RunAverageScore()
    {
        var scores = new double[3];

        for (var i = 0; i < scores.Length; i++)
        {
            scores[i] = InputReader.ReadDouble($"Digite a nota {i + 1}: ", 0, 10);
        }

        var average = scores.Average();

        Console.WriteLine($"\nRelatório:");
        Console.WriteLine($"A média do aluno é {average:0.##}");

        if (average >= 6)
        {
            Console.WriteLine("Aprovado!");
            return;
        }

        if (average < 4)
        {
            Console.WriteLine("Reprovado!");
            return;
        }

        Console.WriteLine("Recuperação!");
    }

    private static void RunTriangleClassification()
    {
        var sides = new double[3];

        for (var i = 0; i < sides.Length; i++)
        {
            sides[i] = InputReader.ReadDouble($"Digite o lado {i + 1} do triângulo: ", double.Epsilon, double.MaxValue);
        }

        if (!IsValidTriangle(sides))
        {
            Console.WriteLine("Os números fornecidos não formam um triângulo válido.");
            return;
        }

        if (sides.All(s => s == sides.First()))
        {
            Console.WriteLine("O triângulo é equiláterio.");
            return;
        }

        if (sides.Distinct().Count() == 3)
        {
            Console.WriteLine("O triângulo é escaleno.");
            return;
        }

        Console.WriteLine("O triângulo é isóceles.");
    }

    private static bool IsValidTriangle(double[] sides)
    {
        if (sides.Length != 3) return false;

        double a = sides[0], b = sides[1], c = sides[2];

        if (a + b <= c || a + c <= b || b + c <= a)
            return false;

        return true;
    }
}