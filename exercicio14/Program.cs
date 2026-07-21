// Faça um programa que pergunte o tamanho de um array de string
// Crie o array e depois  preencha-o utilizando uma estrutura de repetição
// Após preenchido exiba o array na tela para o usuário

Console.WriteLine("Informe o tamanho de array que você deseja:");
int arraySize = int.Parse(Console.ReadLine());

var array = new string[arraySize];

for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine($"Informe a palavra {i+1} que deseja armazenar");
    array[i] = Console.ReadLine();
}

for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine($"Palavra {i+1}: {array[i]}");
}