// Crie um método do tipo void chamado MostrarIdade
// Ele deve receber o ano de nascimento calculando a idade baseado no ano atual

void MostrarIdade(int bornYear, int yearNow)
{
    Console.WriteLine($"Você tem {yearNow - bornYear} anos.");
}

Console.WriteLine("Informe o ano de seu nascimento: ");
int birth = int.Parse(Console.ReadLine());

MostrarIdade(birth, DateTime.Now.Year);