// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int a;

// int b;

// a = 10;

// b = a;

// Console.WriteLine("valor de a:"+a);

// Console.WriteLine("valor de b:"+b);
Console.WriteLine("CalculadoraV2");

int opcion = 0;
double resultado, numero;
Console.WriteLine("Ingrese un opcion:");
int.TryParse(Console.ReadLine(), out opcion);
while (opcion != 0)
{
    switch (opcion)
    {
        case 1:    Console.WriteLine("Ingrese un numero:");
        double.TryParse(Console.ReadLine(), out numero);
            resultado = Math.Abs(numero);
            Console.WriteLine("El VALOR ABSOLUTO del numero es: " + resultado);
            break;
        case 2:
            Console.WriteLine("Ingrese un numero:");
            double.TryParse(Console.ReadLine(), out numero);
            resultado = numero * numero;
            Console.WriteLine("El CUADRADO del numero es: " + resultado);
            break;
        case 3:
            Console.WriteLine("Ingrese un numero:");
            double.TryParse(Console.ReadLine(), out numero);
            if (numero > 0)
            {
                resultado = Math.Sqrt(numero);
                Console.WriteLine("La RAIZ CUADRADA del numero es: " + resultado);
            }
            else
            {
                Console.WriteLine("El numero ingresado es NEGATIVO.");
            }
            break;
        case 4:
            Console.WriteLine("Ingrese un numero:");
            double.TryParse(Console.ReadLine(), out numero);
            resultado = Math.Sin(numero);
            break;
        case 5:
            Console.WriteLine("Ingrese un numero:");
            double.TryParse(Console.ReadLine(), out numero);
            break;
        case 6:
            Console.WriteLine("Ingrese un numero:");
            double.TryParse(Console.ReadLine(), out numero);
            break;
        default:
            Console.WriteLine("El numero ingresado no pertenece a una operacion.");
            break;
    }
    Console.WriteLine("Ingrese un opcion:");
    int.TryParse(Console.ReadLine(), out opcion);
}