// Crie um validador de entrada de dados.
// Enquanto o usuario não digitar um numero entre 1 e 10
// Peça para ele digitar novamente e indique opção errada

bool validador = false;

do
{
    string message = validador ? "Inválido! Tente novamente um número entre 1 e 10" : "Informe um número entre 1 e 10";
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());

    validador = (number >= 1 && number <= 10) ? false : true; 

} while (validador);