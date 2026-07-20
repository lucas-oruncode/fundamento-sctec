// Crie um programa que peça a idade do usuario e informe
// - Se ele é menor de idade
// - Se ele é maior de idade
// - Se ele é maior de idade e idoso (idade >= 60)
// Use if/else e múltiplas condições

Console.WriteLine("Informe sua idade: ");
int age = int.Parse(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("Menor de idade");
}
else if (age >= 60)
{
    Console.WriteLine("Idoso");
}
else
{
    Console.WriteLine("Maior de idade");
}