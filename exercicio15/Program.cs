// Crie um programa que pergunte quantas notas serão adicionadas
// Depois o usuário digita as notas
// Por fim retorne a média das notas


Console.WriteLine("Informe quantas notas serão adicionadas:");
int numGrades = int.Parse(Console.ReadLine());

var grades = new double[numGrades];
double sum = 0;

for (int i = 0; i < numGrades; i++)
{
    Console.WriteLine($"Informe a nota {i+1}");
    grades[i] = double.Parse(Console.ReadLine());

    sum += grades[i];
}

for (int i = 0; i < numGrades; i++)
{
    Console.WriteLine($"Nota {i+1}: {grades[i]} \n-------------");
}

Console.WriteLine($"Média: {sum / numGrades:F3}");