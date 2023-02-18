using System;
using TAREA2.Entidades;
using TAREA2.Negocios;
Console.WriteLine("Ingrese una palabra");
Palabra palabra = new Palabra();
palabra.palabra = Console.ReadLine();

ClsPersona contar = new ClsPersona();
contar.contarPalabra(palabra.palabra);

Console.WriteLine("La palabra " + palabra.palabra + " tiene " + contar.contarPalabra(palabra.palabra) + " letras");
Console.ReadKey();
