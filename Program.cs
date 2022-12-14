// See https://aka.ms/new-console-template for more information
const string saludo = "Buenas, ¿Cual es tu nombre?";
string nombre;
string eleccionUsuario;
int numeroJugador;
int intentos = 3;
Console.WriteLine(saludo);
nombre = Console.ReadLine();
Console.WriteLine($"Buenos días {nombre}, vas a tener que adivianr un número del 1 al 15.");
Console.WriteLine("Tienes 3 intentos, si fallas el programa te dira si tu número es mayor o menor que el que tienes que adivinar.");
var generadorAleatorio = new Random();
int numeroParaAdivinar = generadorAleatorio.Next(1, 15);
for (int i = 0; 1 < 3; i++)
{
    Console.WriteLine("Elige tu número");
    eleccionUsuario = Console.ReadLine();
    numeroJugador = Int32.Parse(eleccionUsuario);
    if (numeroJugador == numeroParaAdivinar)
    {
        Console.WriteLine("!Has adivinado el número¡,!HAS GANADO¡");
        break;
    }
    else if (numeroJugador > numeroParaAdivinar)
    {
        Console.WriteLine("Has fallado, tu número es mayor al que hay que adivinar.");
        Console.WriteLine($"Te quedan {intentos = intentos - 1} intentos.");
    }
    else if (numeroJugador < numeroParaAdivinar)
    {
        Console.WriteLine("Has fallado, tu número es menor al que hay que adivinar.");
        Console.WriteLine($"Te quedan {intentos = intentos - 1}");
    }

    if (intentos == 0)
    {
        Console.WriteLine("Te has quedado sin intentos, has perdido.");
        Console.WriteLine($"El número para advinar era el {numeroParaAdivinar}");
        break;
    }
}