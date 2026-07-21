// Crie um método chamado Subtrair que recebe dois números inteiros como parâmetros.
// O método deve retornar o resultado da subtração do primeiro pelo segundo

int Subtrair(int number1, int number2)
{
    return number1 - number2;
}

Console.WriteLine("Informe dois números para serem subtraídos");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Resultado: {Subtrair(num1, num2)}");