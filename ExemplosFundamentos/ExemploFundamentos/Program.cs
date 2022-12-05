using System;
using ExemploFundamentos.Common.Models;

//DESAFIO PRÁTICO 02

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] p = new string[2];

            for (int contador = 0; contador < n; contador++)
            {                
                p = Console.ReadLine().Split(" ");
                string A = p[0];
                string B = p[1];
                
                if (B.Length > A.Length)
                {
                    Console.WriteLine("nao encaixa");
                }
                else if(A.EndsWith(B))       
                {
                    Console.WriteLine("encaixa");
                }
                else
                {
                    Console.WriteLine("nao encaixa");
                }
            }
        }

    }
}



























/* 
// DESAFIO PRÁTICO 03

int n = int.Parse(Console.ReadLine());
bool resultado = false;

if (n % 1 == 0)
{
    if (n % 2 == 0)
    {  
       if (n == 2)
       {
            resultado = false;
        } 
        else if(n % n == 0)
        {
            resultado = true;
        }
        else
        {
            resultado = false;
        }
    }   
}

Console.WriteLine(resultado);
*/



























































/* DESAFIO PRÁTICO 01

using System;

class DIO {
        
static void Main(string[] args){

        int n = int.Parse(Console.ReadLine());
        int p = 1, s = 0;
        
        while (n > 0)
        {
            int l = n % 10;
           
            int d = n % 100 / 10;            
            if (d == 0)
            {
                p = p * l;
                s = s + l;
            }
            else
            {
                int c = n % 1000 / 100;
                if (c == 0)
                {
                    p = p * l * d;
                    s = s + l + d;
                }
                else
                {
                    int e = n % 10000 / 1000;                
                    if (e == 0)
                    {
                        p = p * l * d * c;
                        s = s + l + d + c;
                    }
                    else
                    {
                        p = p * l * d * c * e;
                        s = s + l + d + c + e;
                    }
                }
            }  

            break;
        }            
            Console.WriteLine(p-s);
        }
    }

*/






// int n = int.Parse(Console.ReadLine());

// int l = n % 10;
// Console.WriteLine(l);

// int d = n % 100 / 10;
// Console.WriteLine(d);

// int c = n % 1000 / 100;
// Console.WriteLine(c);

// int e = n % 10000 / 1000;
// Console.WriteLine(e);

// int f = n % 100000 / 10000;
// Console.WriteLine(f);


























// List<string> listaDeString = new List<string>();

// listaDeString.Add("SP");
// listaDeString.Add("RJ");
// listaDeString.Add("MG");
// listaDeString.Add("PA");

// Console.WriteLine("Percorrendo a lista com FOR");
// for (int contador = 0; contador < listaDeString.Count; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {listaDeString[contador]}");
// }

// Console.WriteLine();

// Console.WriteLine("Percorrendo a lista com FOREACH");
// int contadorForeach = 0;
// foreach (string valor in listaDeString)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
//     contadorForeach++;
// }


































// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 88;
// arrayInteiros[1] = 40;
// arrayInteiros[2] = 12;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo o Array com o FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }























// Console.WriteLine();

// Console.WriteLine("Percorrendo o Array com o FOREACH");
// int contadorForeach = 0;
// foreach (var valor in arrayInteiros)
// {
//     Console.WriteLine($"Posiçaõ Nº {contadorForeach} - {arrayInteiros[contadorForeach]}");
// }





























// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.WriteLine("1 - Cadastar cliente:");
//     Console.WriteLine("2 - Buscar cliente:");
//     Console.WriteLine("3 - Apagar cliente:");
//     Console.WriteLine("4 - Encerrar:");
//     Console.Write("Digite a sua opção: ");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastrar cliente");
//             break;

//         case "2":
//             Console.WriteLine("Buscar cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;

//         case "4":
//             exibirMenu = false;
//             Console.WriteLine("Encerrar");
//             // Environment.Exit(0); /////////Encerra todo o programa a partir dessa linha de código
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// Console.WriteLine("O programa foi encerrado");




























// int numero = 0, soma = 0;

// do
// {
//     Console.Write("Digite um número (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma = soma + numero;
//     //soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");






























// int numero;
// int contador = 0;

// Console.Write("Digite qual será a sua tabuada: ");
// numero = int.Parse(Console.ReadLine());

// while(contador <= 10)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");
//     contador++;
// }






























// Console.WriteLine("TABUADA");

// Console.Write("Digite o número a ser multiplicado até 10: ");
// int numero = int.Parse(Console.ReadLine());

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador} ");
// }



















// Calculadora calc = new Calculadora();

// Console.WriteLine("SOMA");
// Console.Write("Digite o primeiro número: ");
// int primeiroNumero = int.Parse(Console.ReadLine());

// Console.Write("Digite o segundo número: ");
// int segundoNumero = int.Parse(Console.ReadLine());

// calc.Somar(primeiroNumero, segundoNumero);

// Console.WriteLine();

// Console.WriteLine("Subtração");
// Console.Write("Digite o primeiro número: ");
// primeiroNumero = int.Parse(Console.ReadLine());

// Console.Write("Digite o segundo número: ");
// segundoNumero = int.Parse(Console.ReadLine());

// calc.Subtrair(primeiroNumero, segundoNumero);

// Console.WriteLine();

// Console.WriteLine("Multiplicação");
// Console.Write("Digite o primeiro número: ");
// primeiroNumero = int.Parse(Console.ReadLine());

// Console.Write("Digite o segundo número: ");
// segundoNumero = int.Parse(Console.ReadLine());

// calc.Multiplicar(primeiroNumero, segundoNumero);

// Console.WriteLine();

// Console.WriteLine("Divisão");
// Console.Write("Digite o primeiro número: ");
// primeiroNumero = int.Parse(Console.ReadLine());

// Console.Write("Digite o segundo número: ");
// segundoNumero = int.Parse(Console.ReadLine());

// calc.Dividir(primeiroNumero, segundoNumero);

// Console.WriteLine();

// Console.WriteLine("Resto da divisão");
// Console.Write("Digite o primeiro número: ");
// primeiroNumero = int.Parse(Console.ReadLine());

// Console.Write("Digite o segundo número: ");
// segundoNumero = int.Parse(Console.ReadLine());

// calc.Resto(primeiroNumero, segundoNumero);

// Console.WriteLine();

// Console.WriteLine("Potenciação");
// Console.Write("Digite o número: ");
// primeiroNumero = int.Parse(Console.ReadLine());

// Console.Write("Digite o elevado do primeiro número: ");
// segundoNumero = int.Parse(Console.ReadLine());

// calc.Potencia(primeiroNumero, segundoNumero);

// Console.WriteLine();

// Console.WriteLine("CALCULANDO VALORES DO TRIANGULO");
// Console.WriteLine("Seno");
// Console.Write("Digite o valor do angulo: ");
// primeiroNumero = int.Parse(Console.ReadLine());
// calc.Seno(primeiroNumero);

// Console.WriteLine();
// Console.WriteLine("Coseno");
// Console.Write("Digite o valor do angulo: ");
// primeiroNumero = int.Parse(Console.ReadLine());
// calc.Coseno(primeiroNumero);

// Console.WriteLine();
// Console.WriteLine("Tangente");
// Console.Write("Digite o valor do angulo: ");
// primeiroNumero = int.Parse(Console.ReadLine());
// calc.Tangente(primeiroNumero);

// Console.WriteLine();

// Console.WriteLine("INCREMENTANDO E DECREMENTANDO NÚMEROS");
// Console.Write("Digite o número que será incrementado: ");
// primeiroNumero = int.Parse(Console.ReadLine());
// primeiroNumero ++;
// Console.WriteLine($"O número digitado foi incrementado para: {primeiroNumero}");

// Console.WriteLine();

// Console.Write("Digite o número que será decrementado: ");
// primeiroNumero = int.Parse(Console.ReadLine());
// primeiroNumero --;
// Console.WriteLine($"O número digitado foi decrementado para: {primeiroNumero}");

// Console.WriteLine();

// Console.WriteLine("RAIZ QUADRADA");
// Console.Write("Digite um número para calcular a raiz: ");
// primeiroNumero = int.Parse(Console.ReadLine());
// calc.RaizQuadrada(primeiroNumero);

// Pessoa pessoa1 = new Pessoa ();

// pessoa1.Nome = "Luã Lafayete";
// pessoa1.Age = 35;
// pessoa1.Apresentar();

// Console.WriteLine();


