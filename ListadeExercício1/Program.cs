// See https://aka.ms/new-console-template for more information

Console.WriteLine("Cálculo da área de uma circunferência:");

double raio, pi, area;

pi = 3.14;

Console.Write("Digite o valor do raio: ");
raio = Double.Parse(Console.ReadLine());

area = pi * (raio * raio);

Console.WriteLine("O valor da área é de :" + area);