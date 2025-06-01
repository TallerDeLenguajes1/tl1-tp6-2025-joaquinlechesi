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