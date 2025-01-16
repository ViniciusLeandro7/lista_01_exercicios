/*
 
Descrição: Escreva um programa que solicita dois números ao usuário e 
determina qual deles é maior. Utilize if, else if e else para exibir a mensagem 
adequada.

 */

Console.WriteLine("Digite um numero");
double n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite um numero");
double n2 = double.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine("o primeiro número é maior");
}
else if (n2 > n1)
{
    Console.WriteLine("o segundo número é maior");
}
