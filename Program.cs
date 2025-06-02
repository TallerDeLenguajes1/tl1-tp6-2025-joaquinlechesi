// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Obtener la longitud de la cadena y muestre por pantalla.
Console.WriteLine("Ingrese una cadena:");
string cadena;
cadena = Console.ReadLine();
Console.WriteLine("La longitud de la cadena es: " + cadena.Length);

// A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas
// Las cadenas se contatenan con "+"
string cadena2, cadenaFinal;
Console.WriteLine("Ingrese otra cadena:");
cadena2 = Console.ReadLine();
cadenaFinal = cadena + cadena2;
Console.WriteLine("La cadena final es: " + cadenaFinal);

// Extraer una subcadena de la cadena ingresada

// Trabajar con SubString()

Console.WriteLine("Ingrese una nueva cadena:");
cadena = Console.ReadLine();
int subcadena;
Console.WriteLine("Ingrese un numero para obtener una subcadena:");
int.TryParse(Console.ReadLine(), out subcadena);
//cadena2 = Console.ReadLine();
if (subcadena <= cadena.Length)
{
    Console.WriteLine("La subcadena obtenida es: " + cadena.Substring(subcadena));
}
else
{
    Console.WriteLine("El numero ingresado mayor a la longitud de la cadena.");
}

// Utilizando la calculadora creada anteriormente realizar las operaciones de dos números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para la suma sería: “la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.

// int numero = 1, numeroA, numeroB, resultado;
string cadenaNumero;
int num1, num2, resultado;
// Console.WriteLine("Seleccione una opcion:\n1 para realizar una SUMA\n2 para realizar una RESTA\n3 para realizar una MULTIPLICACION\n4 para realizar una DIVISION\n0 para finalizar.");
// cadenaNumero = Console.ReadLine();
// int.TryParse(cadenaNumero, out numero);

Console.WriteLine("Ingrese num1:");
cadenaNumero =  Console.ReadLine();
int.TryParse(cadenaNumero, out num1);
Console.WriteLine("Ingrese num2:");
cadenaNumero =  Console.ReadLine();
int.TryParse(cadenaNumero, out num2);
resultado = num1 + num2;
Console.WriteLine("La suma de 'num1' y de 'num2' es igual a: " + resultado);

// while (numero != 0)
// {
//     switch (numero)
//     {
//         case 1:
// break;

// Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
