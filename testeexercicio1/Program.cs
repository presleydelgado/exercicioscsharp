//Escreva um programa que leia o seu nome digitado e escreva ( hello ... nome)

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


/*
 * 
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

*/

//exercicio 10 : Escreva um programa que pegue 3 números (x,y,z) como input e print (x+y).z e x.y + y.z.

/*
Console.WriteLine("Digite um valor: ");

float numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite outro valor: ");

float numero2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite mais um valor: ");

float numero3 = float.Parse(Console.ReadLine());

float soma = (numero1 + numero2) * numero3;

//-----------------------------------

float xy = numero1 * numero2;
float yz = numero2 * numero3;

float resultado = xy + yz;


Console.WriteLine($"O resultado dos números {numero1} , {numero2} , {numero3}\n será : ({numero1} + {numero2}) * {numero3} O resultado é : {soma} \nE {numero1} X {numero2} + {numero2} X {numero3} O resultado será : {resultado} ");

*/

//exercicio 11 : Faça um programa que pegue uma idade e print algo como "Você parece mais velho que (Idade digitada)

/*
Console.WriteLine("Qual a sua idade ?");
string idade = Console.ReadLine();
Console.WriteLine($"Você aparenta ser mais velho que {idade}");
*/

//exercicio 12 : Escreva um programa que pegue um número e print ele 4 vezes em linha separado por espaços , e dnv mas sem separação.
//console.write {0}.

/*
Console.WriteLine($"Digite um número");

string numero = Console.ReadLine();



Console.Write($"{numero}");
Console.Write($" ");
Console.Write($"{numero}");
Console.Write($" ");
Console.Write($"{numero}");
Console.Write($" ");
Console.Write($"{numero}");
Console.WriteLine();

Console.Write($"{numero}");
Console.Write($"{numero}");
Console.Write($"{numero}");
Console.Write($"{numero}");
Console.WriteLine();

Console.Write($"{numero}");
Console.Write($" ");
Console.Write($"{numero}");
Console.Write($" ");
Console.Write($"{numero}");
Console.Write($" ");
Console.Write($"{numero}");
Console.WriteLine();

Console.Write($"{numero}");
Console.Write($"{numero}");
Console.Write($"{numero}");
Console.Write($"{numero}");
Console.WriteLine();

*/


//Forma mais eficaz e limpa de se fazer:
/*
Console.WriteLine("{0} {0} {0} {0}", numero);
Console.WriteLine("{0}{0}{0}{0}", numero);
Console.WriteLine("{0} {0} {0} {0}", numero);
Console.WriteLine("{0}{0}{0}{0}", numero);

*/

//exercicio 13 : escreva um programa que pegue um numero e mostre num retangulo de 3 colunas de largura e 5 de altura usando o digito.

/*
try
{
    Console.WriteLine("Digite um valor:");

    int numero = int.Parse(Console.ReadLine());

    Console.WriteLine("{0}{0}{0}", numero);
    Console.WriteLine("{0} {0}", numero);
    Console.WriteLine("{0} {0}", numero);
    Console.WriteLine("{0} {0}", numero);
    Console.WriteLine("{0}{0}{0}", numero);

}
catch
{
    Console.WriteLine("Valor não valido");
}

*/

//exercicio 14 : Converta celsius para kevin e fahrenheint

/*
Console.WriteLine("Digite a temperatura em °C: ");
double celsius = double.Parse(Console.ReadLine());
double kelvin = (celsius + 273.15);
double fah = (celsius * 1.8 + 32);

Console.WriteLine($"O valor de {celsius}°C para Kelvin é {kelvin}°K \n Fahrenheit = {fah}°F");

*/

//exercicio 15 : faça um programa que remova um caractere de uma linha 

/*
string aaa = "w3resource";

Console.WriteLine(aaa.Remove(1,1));
Console.WriteLine(aaa.Remove(9));
Console.WriteLine(aaa.Remove(0,1));

//Caralho que coisa mais dificil, a resposta do site não funciona... mas consegui sozinho depois de pesquisar o comando Remove

*/

//exercicio 16 : escreva um programa que crie uma nova string de uma dada string onde o primeiro e ultimo caractere mudem de posição.

string a = "w3resource";
string b = "Python";
string c = "x";


Console.WriteLine($"{a}\n{b}");

