// Upgrade no desafio do caixa eletrônico
// Validador de opção e tratamento de erro caso usuário nao digite opções corretas
// Demonstrativo do extrato, conseguindo visualizar entradas e saídas

int menuOption;
decimal totalValue = 0;
var extract = new List<string>();

do
{
    ShowMenu();

    switch (menuOption)
    {
        case 1:            
            Deposit();
            break;

        case 2:
            Withdraw();
            break;

        case 3:
            ShowBalance();
            break;
        
        case 4:
            ShowExtract();
            break;
        
        case 5:

            Console.WriteLine("-----------------------");
            Console.WriteLine("Encerrando operações...");

            break;

        default:

            Console.WriteLine("-----------------------");
            Console.WriteLine("Opção inválida");

            break;
    }


} while(menuOption != 5);


void ShowMenu()
{
    Console.WriteLine("\n==================================");
    Console.WriteLine("Bem vindo ao Caixa Eletrônico \nInforme a opção desejada:");
    Console.WriteLine("1. Depositar \n2. Sacar \n3. Ver saldo \n4. Extrato \n5. Sair");
    bool isValid = int.TryParse(Console.ReadLine(), out menuOption);

    if (!isValid)
    {
        Console.WriteLine("Opção inválida");
    }
}

void Deposit()
{
    Console.WriteLine("-----------------------");
    Console.WriteLine("1. DEPOSITO \nInforme o valor que deseja depositar:");
    bool isValid = decimal.TryParse(Console.ReadLine(), out decimal deposit);

    if (isValid)
    {
        totalValue += deposit;
        extract.Add($"Depósito: + {deposit:C2}");
        Console.WriteLine($"Você depositou {deposit:C2}");
    } 
    else
    {
        Console.WriteLine("Valor inválido.");
    }
}

void Withdraw()
{
    Console.WriteLine("-----------------------");
    Console.WriteLine("2. SACAR \nInforme o valor que deseja sacar");
    bool isValid = decimal.TryParse(Console.ReadLine(), out decimal withdraw);

    if (isValid)
    {
        if (totalValue >= withdraw)
        {
            totalValue -= withdraw;
            extract.Add($"Saque: - {withdraw:C2}");
            Console.WriteLine($"Você sacou {withdraw:C2}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
    else
    {
        Console.WriteLine("Valor inválido.");
    }
}

void ShowBalance()
{
    Console.WriteLine("-----------------------");
    Console.WriteLine($"3. SALDO DISPONIVEL \nSaldo: {totalValue:C2}");
}

void ShowExtract()
{
    Console.WriteLine("-----------------------");
    Console.WriteLine("4. EXTRATO");
    foreach (var item in extract)
    {
        Console.WriteLine(item);
    }
}