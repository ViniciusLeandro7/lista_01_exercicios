/*
 
 Descrição: Desenvolva um programa que solicita ao usuário um número. O 
programa deve determinar se o número é positivo, negativo ou zero, 
utilizando if, else if, e else para as três possibilidades. Exiba a mensagem 
correspondente

 */

Console.WriteLine("Digite um numero");
int n  = int.Parse(Console.ReadLine());

if (n > 0)
{
    Console.WriteLine($"o número {n} é positivo");
}

else if (n < 0)
{   
    Console.WriteLine($"o número {n} é positivo");
}

else
{
    Console.WriteLine($"o número {n} é zero");
}