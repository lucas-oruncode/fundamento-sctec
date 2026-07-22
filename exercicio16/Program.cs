// Criar um menu que adiciona, mostra ou sai do programa
// Usando listas


var groceriesList = new List<string>();
int option;

do
{
    Console.WriteLine("Menu de compras");
    Console.WriteLine("1. Adicionar item \n2. Mostar lista \n3. Sair");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:

            Console.WriteLine("Informe o item que deseja adicionar:");
            groceriesList.Add(Console.ReadLine());

        break;

        case 2:

            Console.WriteLine("Lista de compras:");
            foreach(var item in groceriesList)
            {
                Console.WriteLine($"- {item}");
            }
        break;

        case 3:

            Console.WriteLine("Saindo...");
        
        break;

        default:

            Console.WriteLine("Opção inválida!");
        break;
    }

} while (option != 3);