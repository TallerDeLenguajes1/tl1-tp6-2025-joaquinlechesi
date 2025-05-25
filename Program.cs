// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int a;

// int b;

// a = 10;

// b = a;

// Console.WriteLine("valor de a:"+a);

// Console.WriteLine("valor de b:"+b);
Console.WriteLine("CalculadoraV2");

int opcion = 0, numero;
float resultado;
Console.WriteLine("Ingrese un opcion:");
int.TryParse(Console.ReadLine(), out opcion);
while (opcion != 0)
{
    Console.WriteLine("Ingrese un numero:");
    int.TryParse(Console.ReadLine(), out numero);
    switch (opcion)
    {
        case 1:
            resultado = Math.Abs(numero);
            Console.WriteLine("El VALOR ABSOLUTO del numero es: " + resultado);
            break;
        case 2:
            resultado = numero * numero;
            Console.WriteLine("El CUADRADO del numero es: " + resultado);
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
        default:
            break;
    }
    Console.WriteLine("Ingrese un opcion:");
    int.TryParse(Console.ReadLine(), out opcion);
}