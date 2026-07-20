// Leia um numero inteiro N. Se N for positivo, imprima "Positivo", caso contrario "Não Positivo"

Console.WriteLine("Informe um numero:");
int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("Positivo");
}
else
{
    Console.WriteLine("Não Positivo");
}