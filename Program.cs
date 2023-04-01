// See https://aka.ms/new-console-template for more information
//  VARIABLES
int option;
double A;
double B;
double resultado;
string mensaje;

//Dibujar Menu
Console.WriteLine("***** CALCULADORA *****");
Console.WriteLine("1. SUMAR.");
Console.WriteLine("2. RESTAR.");
Console.WriteLine("3. MULTIPLICAR.");
Console.WriteLine("4. DIVIDIR.");
Console.WriteLine("5. ELEVAR A LA POTENCIA.");
Console.Write("SELECCIONE UNA OPCIÓN (1-5):");

//GUARDAR VARIABLES
option = int.Parse(Console.ReadLine());

//AHORA PEDIMOS LOS DOS NUMEROS
Console.Write("Ingrese el primer numero: ");
A = double.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo numero: ");
B = double.Parse(Console.ReadLine());
