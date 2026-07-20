// Um banco precisa decidir se um cliente pode receber crédito
// Regras:
// 1. Renda mensal >= 3000
// 2. Nome não pode estar negativado
// 3. Idade entre 18 e 65
// 4. Se renda >= 8000 e não negativado -> aprovação automática
// 5. Caso contrário, aplicar regras normais
// 6. Se qualquer regra falhar -> crédito negato

Console.WriteLine("Informe o salário:");
decimal salary = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe a idade:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Informe se o usuário está negativado: \n[1]Negativado \n[2]Não negativado");
int isBlacklistedOption = int.Parse(Console.ReadLine());
bool isBlacklisted = (isBlacklistedOption == 1) ? true : false;

if (age <= 65 && age >= 18)
{
    if (salary >= 8000 && !isBlacklisted)
    {
        Console.WriteLine("Cliente aprovado automaticamente!");
    }
    else if (salary < 3000 || isBlacklisted)
    {
        Console.WriteLine("Não aprovado!");
    }
    else
    {
        Console.WriteLine("Crédito em análise!");
    }
}
else
{
    Console.WriteLine("Não aprovado!");
}