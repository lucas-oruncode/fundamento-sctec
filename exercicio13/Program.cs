// Crie um método chamado VerificarPar que recebe um número inteiro
// O método deve ter retorno bool
// Retorne true se for par e salse se for ímpar

bool VerificarPar(int number)
{
    return (number % 2 == 0) ? true : false;
}

Console.WriteLine("Informe um número");
int number = int.Parse(Console.ReadLine());

string message = VerificarPar(number) ? "É par." : "É ímpar.";
Console.WriteLine(message);