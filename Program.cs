// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int a;

// int b;

// a = 10;

// b = a;

// Console.WriteLine("valor de a:"+a);

// Console.WriteLine("valor de b:" + b);

// Console.WriteLine("INVERTIR NUMERO");

// string cadenaNumero = Console.ReadLine();
// int numero;
// int.TryParse(cadenaNumero, out numero);
// int aux = 0;

// if (numero > 0)
// {
//     while (numero > 10)
//     {
//         aux = aux * 10 + numero % 10;
//         numero = numero / 10;
//     }
//     aux = aux * 10 + numero;
// }else
// {
//     aux = numero;
// }
// Console.WriteLine(aux);

Console.WriteLine("CalculadoraV1");

string cadenaNumero;
int numero = 1, numeroA, numeroB, resultado;
Console.WriteLine("Seleccione una opcion:\n1 para realizar una SUMA\n2 para realizar una RESTA\n3 para realizar una MULTIPLICACION\n4 para realizar una DIVISION\n0 para finalizar.");
cadenaNumero = Console.ReadLine();
int.TryParse(cadenaNumero, out numero);

while (numero != 0)
{
    switch (numero)
    {
        case 1:
            Console.WriteLine("Ingrese el primer numero:");
            cadenaNumero =  Console.ReadLine();
            int.TryParse(cadenaNumero, out numeroA);
            Console.WriteLine("Ingrese el segundo numero:");
            cadenaNumero =  Console.ReadLine();
            int.TryParse(cadenaNumero, out numeroB);
            resultado = numeroA + numeroB;
            Console.WriteLine("El resultado de la operacion suma es: " + resultado);
            break;
        case 2:
            Console.WriteLine("Ingrese el primer numero:");
            cadenaNumero =  Console.ReadLine();
            int.TryParse(cadenaNumero, out numeroA);
            Console.WriteLine("Ingrese el segundo numero:");
            cadenaNumero =  Console.ReadLine();
            int.TryParse(cadenaNumero, out numeroB);
            resultado = numeroA - numeroB;
            Console.WriteLine("El resultado de la operacion resta es: " + resultado);
            break;
        case 3:
            Console.WriteLine("Ingrese el primer numero:");
            cadenaNumero =  Console.ReadLine();
            int.TryParse(cadenaNumero, out numeroA);
            Console.WriteLine("Ingrese el segundo numero:");
            cadenaNumero =  Console.ReadLine();
            int.TryParse(cadenaNumero, out numeroB);
            resultado = numeroA * numeroB;
            Console.WriteLine("El resultado del operacion producto es: " + resultado);
            break;
        case 4:
            Console.WriteLine("Ingrese el primer numero:");
            cadenaNumero =  Console.ReadLine();
            int.TryParse(cadenaNumero, out numeroA);
            Console.WriteLine("Ingrese el segundo numero:");
            cadenaNumero =  Console.ReadLine();
            int.TryParse(cadenaNumero, out numeroB);
            resultado = numeroA / numeroB;
            Console.WriteLine("El resultado de la operacion division es: " + resultado);
            break;
        default:
            Console.WriteLine("El numero ingresado no pertenece a una operacion.");
            break;
    }
    Console.WriteLine("Seleccione una opcion:\n1 para realizar una SUMA\n2 para realizar una RESTA\n3 para realizar una MULTIPLICACION\n4 para realizar una DIVISION\n0 para finalizar.");
    cadenaNumero = Console.ReadLine();
    int.TryParse(cadenaNumero, out numero);
}