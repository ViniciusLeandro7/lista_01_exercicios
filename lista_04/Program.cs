/*
 Descrição: Crie um programa que verifique se um número digitado pelo 
usuário está dentro do intervalo de 1 a 100. Utilize uma condição if para 
verificar se o número está no intervalo e exiba uma mensagem informando 
o resultado.
 */

Console.WriteLine("Digite um numero");
int n = int.Parse(Console.ReadLine());

if (n >= 1 && n <= 100)
{
    Console.WriteLine($"O número está dentro do intervalo");
}
else
{
    Console.WriteLine($"o número não esta dentro do intervalo");
}