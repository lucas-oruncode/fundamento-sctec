// SIMULADOR DE LOGIN COM TENTATIVAS LIMITADAS
// Crie um sistema que peça usuário e senha
// O usuário tem 3 tentativas
// Se errar 3 vezes, o sistema bloqueia o acesso
// Se acertar, exibe "Login realizado com sucesso"

string user = "usuario";
string password = "senha123";
int attempts = 3;

do
{

    Console.Write("Informe o usuário: ");
    user = Console.ReadLine();

    Console.Write("Informe a senha: ");
    password = Console.ReadLine();

    if (user == "usuario" && password == "senha123")
    {
        Console.WriteLine("Login realizado com sucesso!");
        attempts = 0;
    } else
    {
        Console.WriteLine($"Usuário ou senha incorreto. Tente novamente. \nTentativas: {attempts}");
        attempts--;
        string message = (attempts < 0) ? "Acesso bloqueado!" : "";
        Console.WriteLine(message);
    }
} while (attempts >= 0);