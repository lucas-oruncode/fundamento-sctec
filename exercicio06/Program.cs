// Uma transportadora precisa calcular o frete com base em:
// - Distância
// - Peso de carga
// - Tipo de cliente: comum e premium
// - Regras:
// - Frete base = distância * 1.5
// - Se peso > 100 -> adicionar taxa de 12%
// - Cliente premium tem desconto de 15%, exceto peso > 200
// - Se distância > 1000 e peso > 150 -> aplicar taxa extra de risco (8%)
// - Se qualquer valor for inválido (negativo) -> erro

Console.WriteLine("Informe a distância em km:");
double distance = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o peso da carga em kg:");
double weight = double.Parse(Console.ReadLine());

Console.WriteLine("O cliente é premium? \n- Sim \n- Não");
string premiumOption = Console.ReadLine();
bool premium = (premiumOption.ToLower() == "sim") ? true : false;

double fare = distance * 1.5;

if (weight < 1 || distance < 1)
{
    Console.WriteLine("Não é permitido peso ou distância zerados!");

} else {
    if (weight > 100)
    {
        fare *= 1.12;

        if ( distance > 1000 && weight > 150)
        {
            fare *= 1.08;
        }
    }

    fare = premium ? (fare * 0.85) : fare;
    Console.WriteLine($"Total do frete: {fare:C2}");    

}

