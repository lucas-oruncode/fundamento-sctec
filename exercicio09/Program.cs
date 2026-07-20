// Calcule o fatorial de N (obtido pelo usuario)
// Utilizando estruturas de repetição

Console.WriteLine("Informe o numero para calcular o fatorial:");
bool isNumber = int.TryParse(Console.ReadLine(), out int i);

while (!isNumber)
{
    Console.WriteLine("Inválido. Informe um numero inteiro");
    isNumber = int.TryParse(Console.ReadLine(), out i);
}

if ( i == 0)
{
    Console.WriteLine("Fatorial de 0 é sempre 1");
}
else
{
    int fatorial = 1;

    int fw = i;
    while(fw >= 1)
    {
        Console.WriteLine(i);
        fatorial *= fw;
        fw--;
    }

    Console.WriteLine("Fatorial while: " + fatorial);

    fatorial = 1;

    int fd = i;
    do
    {
        fatorial *= fd;
        fd--;
    }while (fd > 1);

    Console.WriteLine("Fatorial do: " + fatorial);

    fatorial = 1;

    for(int ff = i; ff >= 1; ff--)
    {
        fatorial *= ff;
    }

    Console.WriteLine("Fatorial for: " + fatorial);
}