using ConsoleApp.API;
using ConsoleApp.Exercises;

Ex chosenExercise;

var availableExercises = new List<Ex>
{
    new Ex1(),
    new Ex2(),
    new Ex3(),
    new Ex4(),
    new Ex5(),
};

int input, exerciseCount = availableExercises.Count;

while (true)
{
    input = InputReader.ReadInt($"Digite o exercício desejado: (0 pra sair) (1 à {exerciseCount})", 0, exerciseCount);

    if (input == 0)
        break;

    chosenExercise = availableExercises[input - 1];

    chosenExercise.Execute();
}

Console.WriteLine("Aperte qualquer tecla para finalizar o programa.");
Console.ReadKey();