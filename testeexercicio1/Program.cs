﻿//Escreva um programa que leia o seu nome digitado e escreva ( hello ... nome)

/*Console.WriteLine("What's is your name ?");
string name = Console.ReadLine();
Console.WriteLine("Hello: " + name);
*/


//exercicio 2 , Some dois números :
/*
Console.WriteLine("Digite um valor ");

double numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite outro valor");

double numero2 = double.Parse(Console.ReadLine());

double soma = numero1 + numero2;

Console.WriteLine("A soma dos dois valores digitados é : " + soma);
*/

//exercicio 3 : Divida dois números :

/*

Console.WriteLine("Digite um valor a ser divido:");

double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite outro valor : ");

double num2 = double.Parse(Console.ReadLine());

double div = num1 / num2;

Console.WriteLine("A divisão dos dois números apresentados é : " +  div);
*/

/*exercicio 4 : Escreva um programa que print os resultados das seguintes operações
Test data:

1:  -1 + 4 * 6
2:  (35 + 5) % 7
3:  14 + -4 * 6 / 11
4:  2 + 15 / 6 * 1 - 7 % 2

Expected Output:
23
5
12
3 
*/


/*

Console.WriteLine($"Operação número 1 : -1 + 4 * 6");
double op1 = -1 + (4 * 6);

Console.Write($"O resultado é {op1}");



Console.WriteLine("\nOperação número 2 : (35 + 5) % 7");
double op2 = (35 + 5) % 7;

Console.WriteLine($"O resultado é {op2}");



Console.WriteLine("Operação número 3 : 14 + -4 * 6 / 11");
double op3 = (-4 * 6) / 11 + 14;

Console.WriteLine($"O resultado é {op3}");



Console.WriteLine("Operação número 4 : 2 + 15 / 6 * 1 - 7 % 2");
double op4 = 2 + 15 / 6 * 1 - 7 % 2;

Console.WriteLine($"O resultado é {op4}");

//acertei as três primeira sozinho e só errei na ultima

*/

//exercicio 5 : Faça um programa que mude dois números de posição :

/*
Console.WriteLine("Digite um valor:");
float numero1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite outro valor:");
float numero2 = float.Parse(Console.ReadLine());
Console.WriteLine($"Os números depois de serem trocados foram : \nPrimeiro Valor: {numero2} \nSegundo Valor: {numero1}");

*/

//exercicio 6 : multiplique 3 números :

/*
try
{
    
    Console.WriteLine("Digite um número a ser multiplicado por outros 2 números:");
    double num1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro valor:");
    double num2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite um valor final:");
    double num3 = double.Parse(Console.ReadLine());

    double multi = num1 * num2 * num3;

    Console.WriteLine($"A multiplicação dos três valores apresentados é : {multi}");
}
catch
{
    Console.WriteLine("Valor digitado é invalido!");
}
*/

//exercicio 7 : Escreva um programa que some , multiplique, subtraia e divida dois valores digitados pelo usuario 

/*
 * 
try
{
    Console.WriteLine("Digite um valor:");
    double valor1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro valor:");
    double valor2 = double.Parse(Console.ReadLine());

    double soma = valor1 + valor2;
    double subtração = valor1 - valor2;
    double multi = valor1 * valor2;
    double divisao = valor1 / valor2;
    double mod = valor1 % valor2;

    Console.WriteLine($"{valor1} + {valor2} = {soma}");
    Console.WriteLine($"{valor1} - {valor2} = {subtração}");
    Console.WriteLine($"{valor1} * {valor2} = {multi}");
    Console.WriteLine($"{valor1} / {valor2} = {divisao}");
    Console.WriteLine($"{valor1} % {valor2} = {mod}");
}
catch
{
    Console.WriteLine("O valor digitado não é um número!!!");
}

*/

//exercicio 8 : Faça um programa que mostre a tabuada do numero digitado

/*
 * 
Console.WriteLine("Digite um número :");
int numero1 = int.Parse(Console.ReadLine());
int numero2 = 0;


do
{
    int multi = numero1 * numero2;
    Console.WriteLine($"Tabuada do = {numero1} X {numero2} = {multi}");
    numero2++;

}while(numero2 <= 10);

*/

//exercicio 9 : De a media de 4 números inputados

Console.WriteLine("Digite um número:");

float num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número:");

float num2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número:");

float num3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número:");

float num4 = float.Parse(Console.ReadLine());

float media = num1 + num2 + num3 + num4 ;
float mediaresult = media / 4;

Console.WriteLine($"A média dos números {num1} , {num2} , {num3} , {num4} é {mediaresult}");   






