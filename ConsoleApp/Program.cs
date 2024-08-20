using ConsoleApp.API;
using ConsoleApp.Exercises;

Ex chosenExercise;

int input;

var availableExercises = new List<Ex> {
    new Ex1(),
    new Ex2(),
    new Ex3(),
    new Ex4()
};

while (true)
{
    input = InputReader.ReadInt("Digite o exercício desejado: (0 pra sair) (1 à 3)", 0, 3);

    if (input is 0)
        break;

    chosenExercise = availableExercises[input - 1];

    chosenExercise.Execute();
}

Console.ReadKey();