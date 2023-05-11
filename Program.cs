﻿Console.WriteLine("a continuación podrás escribir dos números para poderlos sumar, restar, multiplicar o dividir");
Console.WriteLine("escriba el primer número");
var primernum = Console.ReadLine();
int num1 = int.Parse(primernum);
Console.WriteLine("escriba el seguno número");
var segundonum = Console.ReadLine();
int num2 = int.Parse(segundonum);
Suma(num1,num2);
static int Suma(int suma1, int suma2)
{
    int resultado = suma1 + suma2;
    Console.WriteLine("la suma de  " + suma1 + " y " + suma2 + " es: " + resultado);
    return resultado;
}
Resta(num1,num2);
static int Resta(int minuendo, int sustraendo)
{
    int resultado = minuendo - sustraendo;
    Console.WriteLine("la resta de  " + minuendo + " y " + sustraendo + " es: " + resultado);
    return resultado;
}
Producto(num1,num2);
static int Producto(int Fact1, int Fact2)
{
    int resultado = Fact1 * Fact2;
    Console.WriteLine("la multiplicación de  " + Fact1 + " y " + Fact2 + " es: " + resultado);
    return resultado;
}
Division(num1,num2);
static int Division(int Divi, int div)
{
    int resultado = Divi / div;
    Console.WriteLine("la divisón de  " + Divi + " y " + div + " es: " + resultado);
    return resultado;
}