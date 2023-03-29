using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace @if
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EXEC 1
            //float azul=0;
            //Console.WriteLine("quantas laranjas você comprou?");
            //    azul = float.Parse(Console.ReadLine());
            //if (azul <= 11)
            //    Console.WriteLine("O valor da comprar deu: " + azul * 0.35);
            //else
            //{
            //    Console.WriteLine("O valor da comprar deu: " + azul * 0.28);
            //}

            //EXEC 2
            //int ano, idade;
            //Console.WriteLine("qual o ano do seu nacimento");
            //ano = int.Parse(Console.ReadLine());
            //idade = 2023 - ano;
            //if (idade >= 16)
            //    Console.WriteLine("você pode votar");
            //else

            //    Console.WriteLine("você não pode votar");

            //EXEC 3
            //float lado1, lado2, lado3;

            //Console.WriteLine("digite o valor do primeiro lado");
            //lado1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("digite o valor do segundo lado");
            //lado2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("digite o valor do terceiro lado");
            //lado3 = float.Parse(Console.ReadLine());

            //if (lado1 == lado2 && lado2 == lado3)
            //{
            //    Console.WriteLine("esse triangulo é equilatero");
            //}
            //else
            //{
            //    if (lado1 == lado2 || lado2 == lado3||lado1==lado3)
            //    {

            //        Console.WriteLine("ele é um  triangulo  isósceles ");


            //    }
            //    else
            //    {
            //        Console.WriteLine("ele é um triangulo escaleno"); 
            //    }

            //}

            //EXEC 4

            //   double a, b, c, delta, bask;

            //Console.WriteLine("digite o valor de a:");
            //a = double.Parse(Console.ReadLine());

            //Console.WriteLine("digite o valor de b:");
            //b = double.Parse(Console.ReadLine());

            //Console.WriteLine("digite o valor de c:");
            //c = double.Parse(Console.ReadLine());


            //if (a == 0 && b == 0 && c == 0)
            //{
            //    Console.WriteLine("A, B e C devem ser diferentes de 0!");
            //}
            //else
            //{
            //    delta = (b * b) * (-4 * (a * c));
            //    if (delta < 0)
            //    {
            //        Console.WriteLine("Delta não pode ser menor que 0!");
            //    }
            //    else if (delta == 0)
            //    {
            //        bask = -b / (2 * a);
            //    }
            //    else
            //    {
            //        bask = -b + Math.Sqrt(delta) / (2 * a);
            //        Console.WriteLine(String.Format("1º Valor da Equação do segundo grau: ", bask));
            //        bask = -b - Math.Sqrt(delta) / (2 * a);
            //        Console.WriteLine(String.Format("2º Valor da Equação do segundo grau: ", bask));

            //EXEC 5

            //int num;
            //Console.WriteLine("digite seu número");
            //num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 5 == 0)
            //{
            //    Console.WriteLine("seu número é divisivel por 3 e 5");
            //}
            //else
            //{
            //    if (num % 3== 0)
            //    {
            //        Console.WriteLine("ele é divisilvel por 3");
            //    }
            //    else if (num %5==0)
            //    {
            //        Console.WriteLine("ele é divisilvel por 5");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("ele não é divisilvel por 3 ou 5");
            //    }
            //}

            //EXEC 6

            //int tri1, tri2, tri3;

            //Console.WriteLine("digite seu primeiro ângulo");
            //tri1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite seu segundo ângulo");
            //tri2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("digite seu teceiro ângulo");
            //tri3 = int.Parse(Console.ReadLine());

            //if (tri1 == 90 || tri2 == 90 || tri3 == 90)
            //{
            //    Console.WriteLine("Esse triangulo é retângulo");
            //}
            //else
            //{
            //    if (tri1 >= 90 || tri2 >= 90 || tri3 >= 90)
            //    {
            //        Console.WriteLine("Esse triangulo é Obtusângulo");
            //    }
            //    else if (tri1 <= 90 && tri2 <= 90 && tri3 <= 90)
            //    {
            //        Console.WriteLine("Esse triangulo é Acutângulo:");
            //    }

            //}

            //EXEC 7

            //Console.WriteLine("Digite três valores inteiros diferentes:");

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a < b && a < c)
            //{
            //    if (b < c)
            //    {
            //        Console.WriteLine($"{a}, {b}, {c}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{a}, {c}, {b}");
            //    }
            //}
            //else if (b < a && b < c)
            //{
            //    if (a < c)
            //    {
            //        Console.WriteLine($"{b}, {a}, {c}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{b}, {c}, {a}");
            //    }
            //}
            //else if (c < a && c < b)
            //{
            //    if (a < b)
            //    {
            //        Console.WriteLine($"{c}, {a}, {b}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{c}, {b}, {a}");
            //    }
            //}

            //EXEC 8

            //Console.Write("Digite um ano: ");
            //int ano = int.Parse(Console.ReadLine());

            //if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            //{
            //    Console.WriteLine($"{ano} é um ano bissexto.");
            //}
            //else
            //{
            //    Console.WriteLine($"{ano} não é um ano bissexto.");
            //}

            //EXEC 9

            //Console.Write("Digite o primeiro número: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Digite o segundo número: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.Write("Digite o operador (+, -, * ou /): ");
            //char operador = char.Parse(Console.ReadLine());

            //double resultado = 0;

            //if (operador == '+')
            //{
            //    resultado = num1 + num2;
            //}
            //else if (operador == '-')
            //{
            //    resultado = num1 - num2;
            //}
            //else if (operador == '*')
            //{
            //    resultado = num1 * num2;
            //}
            //else if (operador == '/')
            //{
            //    resultado = num1 / num2;
            //}
            //else
            //{
            //    Console.WriteLine("Operador inválido.");
            //    return;
            //}

            //Console.WriteLine($"O resultado da operação é: {resultado}");
        }
    } 
}