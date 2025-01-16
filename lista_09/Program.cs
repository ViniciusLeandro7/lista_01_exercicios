/*
Descrição: Desenvolva um programa que peça um número de 1 a 7 e exiba 
o dia da semana correspondente (1 para "Domingo", 2 para "Segunda-feira", 
etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de 
erro.
 */

Console.WriteLine("Digite um número");
int n = int.Parse(Console.ReadLine());

if (n == 1)
{
    Console.WriteLine("Domingo");
}

else if (n == 2)
{
    Console.WriteLine("Segunda Feira");
}

else if (n == 3)
{
    Console.WriteLine("Terça Feira");
}
else if (n == 4)
{
    Console.WriteLine("Quarta Feira");
}
else if(n == 5)
{
    Console.WriteLine("Quinta Feira");
}
else if (n == 6)
{
    Console.WriteLine("Sexta Feira");
}
else if (n == 7)
{
    Console.WriteLine("Sabado");
}