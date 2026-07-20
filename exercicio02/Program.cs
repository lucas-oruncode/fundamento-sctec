// Leia um numero inteiro N, verifique se N é multiplo de 5, se for imprimir "Multiplo de 5", caso contrario imprimir "Não é multiplo de 5"

Console.WriteLine("Informe um numero:");
int number = int.Parse(Console.ReadLine());

if (number %  5 == 0)
{
    Console.WriteLine("Múltiplo de 5");
}
else
{
    Console.WriteLine("Não é multiplo de 5");
}