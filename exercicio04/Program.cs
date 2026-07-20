// Peça o valor da compra e informe:
// - Se valor >= 500 -> Desconto de 20%
// - Se valor entre 200 e 499 -> Desconto de 10%
// - Se valor < 200 -> Sem desconto

Console.WriteLine("Informe o valor da compra:");
decimal valor = decimal.Parse(Console.ReadLine());

if (valor < 200)
{
    Console.WriteLine($"Valor da compra: {valor:C2}");
}
else if(valor >= 500)
{
    Console.WriteLine($"Você recebeu {valor*0.2m:C2} de desconto \nValor sem desconto: {valor:C2} \nValor com desconto: {valor*0.8m:C2}");
}
else
{
    Console.WriteLine($"Você recebeu {valor*0.1m:C2} de desconto \nValor sem desconto: {valor:C2} \nValor com desconto: {valor*0.9m:C2}");
}