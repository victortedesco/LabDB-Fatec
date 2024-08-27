using ConsoleApp.API;
using ConsoleApp.Exercises;

Ex chosenExercise;

var availableExercises = new List<Ex>
{
    new Ex1(),
    new Ex2(),
    new Ex3(),
    new Ex4(),
};

int input, exerciceCount = availableExercises.Count;

while (true)
{
    input = InputReader.ReadInt($"Digite o exercício desejado: (0 pra sair) (1 à {exerciceCount})", 0, exerciceCount);

    if (input == 0)
        break;

    chosenExercise = availableExercises[input - 1];

    chosenExercise.Execute();
}

Console.WriteLine("Aperte qualquer tecla para finalizar o programa.");
Console.ReadKey();