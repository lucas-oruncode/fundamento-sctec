// Crie um menu de aplicação interativo e englobe os exercicios anteriores
// para selecionar qual sera executado
// 1. Tabuada
// 2. Input validator
// 3. Fatorial
// 4. Sair

int option = 0;

do
{
    Console.WriteLine("Menu de opções \nInforme uma das opções abaixo:");
    Console.WriteLine("1. Tabuada \n2. Input validator \n3. Fatorial \n4. Sair");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine("Informe um numero para tabuada: ");
            int tabuada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{tabuada} x {i} = {i*tabuada}");
            }

            break;

        case 2:

            bool validador = false;

            do
            {
                string message = validador ? "Inválido! Tente novamente um número entre 1 e 10" : "Informe um número entre 1 e 10";
                Console.WriteLine(message);
                int number = int.Parse(Console.ReadLine());

                validador = (number >= 1 && number <= 10) ? false : true; 

            } while (validador);

            break;

        case 3:

            Console.WriteLine("Informe o numero para calcular o fatorial:");
            bool isNumber = int.TryParse(Console.ReadLine(), out int index);

            while (!isNumber)
            {
                Console.WriteLine("Inválido. Informe um numero inteiro");
                isNumber = int.TryParse(Console.ReadLine(), out index);
            }

            if ( index == 0)
            {
                Console.WriteLine("Fatorial de 0 é sempre 1");
            }
            else
            {
                int fatorial = 1;

                while(index >= 1)
                {
                    Console.WriteLine(index);
                    fatorial *= index;
                    index--;
                }

                Console.WriteLine("Fatorial: " + fatorial);
            }

            break;

        case 4:

            Console.Write("Saindo do programa");

            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;

    }  

    Console.WriteLine("=======================================");

} while (option != 4);