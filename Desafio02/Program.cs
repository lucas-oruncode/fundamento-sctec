// SIMULADOR DE CAIXA ELETRONICO
// Crie um sistema que:
// Exibe um menu com opções:
// - Depositar
// - Sacar
// - Ver Saldo
// - Sair
// Menu deve aparecer pelo menos uma vez
// Saldo não pode ficar negativo
// O usuário deve conseguir fazer várias operações até escolher sair

int menuOption;
decimal totalValue = 0;

do
{
    Console.WriteLine("==================================");
    Console.WriteLine("Bem vindo ao Caixa Eletrônico \nInforme a opção desejada:");
    Console.WriteLine("1. Depositar \n2. Sacar \n3. Ver saldo \n4. Sair");
    bool isValid = int.TryParse(Console.ReadLine(), out menuOption);

    if (!isValid)
    {
        Console.WriteLine("Opção inválida");
    }

    switch (menuOption)
    {
        case 1:

            Console.WriteLine("-----------------------");
            Console.WriteLine("1. DEPOSITO \nInforme o valor que deseja depositar:");
            isValid = decimal.TryParse(Console.ReadLine(), out decimal deposit);

            if (isValid)
            {
                totalValue += deposit;
                Console.WriteLine($"Você depositou {deposit:C2}");
            } 
            else
            {
                Console.WriteLine("Valor inválido.");
            }

            break;

        case 2:

            Console.WriteLine("-----------------------");
            Console.WriteLine("2. SACAR \nInforme o valor que deseja sacar");
            isValid = decimal.TryParse(Console.ReadLine(), out decimal withdraw);

            if (isValid)
            {
                if (totalValue >= withdraw)
                {
                    totalValue -= withdraw;
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

            break;

        case 3:

            Console.WriteLine("-----------------------");
            Console.WriteLine($"3. SALDO DISPONIVEL \nSaldo: {totalValue:C2}");

            break;
        
        case 4:

            Console.WriteLine("-----------------------");
            Console.WriteLine("Encerrando operações...");

            break;

        default:

            Console.WriteLine("-----------------------");
            Console.WriteLine("Opção inválida");

            break;
    }


} while(menuOption != 4);