using System.Diagnostics.CodeAnalysis;

int a, b, c, maior;

Console.Clear();
Console.Write("Escreva o primeiro número: ");
a = Convert.ToInt16(Console.ReadLine());

Console.Write("Escreva o segundo número: ");
b = Convert.ToInt16(Console.ReadLine());

Console.Write("Escreva o terceiro número: ");
c = Convert.ToInt16(Console.ReadLine());
 

if (a >= b && a >= c)
    maior = a;
else if (b >= a && b >= c)
    maior = b;
else
    maior = c;

Console.WriteLine("o maior numero é: " + maior);
