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
Console.WriteLine("Ingrese un numero para una opcion:\n1 para calcular el VALOR ABSOLUTO\n2 para calcular el CUADRADO\n3 para calcular la RAIZ CUADRADA\n4 para calcular el SENO\n5 para calcular el COCENO\n6 para calcular la PARTE ENTERA de un numero real");
int.TryParse(Console.ReadLine(), out opcion);
while (opcion != 0)
{
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese un numero:");
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
            Console.WriteLine("El SENO del numero es: " + resultado);
            break;
        case 5:
            Console.WriteLine("Ingrese un numero:");
            double.TryParse(Console.ReadLine(), out numero);
            resultado = Math.Cos(numero);
            Console.WriteLine("El COSENO del numero es: " + resultado);
            break;
        case 6:
            Console.WriteLine("Ingrese un numero real usando COMA:");
            double.TryParse(Console.ReadLine(), out numero);
            resultado = Math.Truncate(numero);
            Console.WriteLine("La PARTE ENTERA del numero ingreado es:" + resultado);
            break;
        default:
            Console.WriteLine("El numero ingresado no pertenece a una operacion.");
            break;
    }
    Console.WriteLine("Ingrese un numero para una opcion:\n1 para calcular el VALOR ABSOLUTO\n2 para calcular el CUADRADO\n3 para calcular la RAIZ CUADRADA\n4 para calcular el SENO\n5 para calcular el COCENO\n6 para calcular la PARTE ENTERA de un numero real");
    int.TryParse(Console.ReadLine(), out opcion);
}

int primerNumero, segundoNumero;
Console.WriteLine("Ingrese dos numeros para determinar el MAXIMO y el MINIMO\nIngrese el primer numero:");
int.TryParse(Console.ReadLine(), out primerNumero);
Console.WriteLine("Ingrese el segundo numero:");
int.TryParse(Console.ReadLine(), out segundoNumero);
Console.WriteLine("El MAXIMO entre los numeros ingresados es " + Math.Max(primerNumero, segundoNumero) + " y el MINIMPO es " + Math.Min(primerNumero, segundoNumero));

Console.WriteLine("Fin del programa.");