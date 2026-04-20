/*
 * Ejercicio 2: Conteo de caracteres y palabras
 */
using System;

class Ejercicio2
{
    static void Main()
    {
        Console.WriteLine("Ingrese un texto (termine con el símbolo $):");
        string texto = Console.ReadLine();

        int contadorVocales = 0;
        int contadorPalabras = 0;
        bool enPalabra = false;

        if (string.IsNullOrEmpty(texto)) return;

        foreach (char c in texto)
        {
            // Señal de finalización
            if (c == '$') break;

            char lowerC = char.ToLower(c);

            // Contar vocales
            if ("aeiouáéíóú".Contains(lowerC))
            {
                contadorVocales++;
            }

            // Contar palabras asumiendo que el espacio o el punto las separan
            if (c == ' ' || c == '.')
            {
                if (enPalabra)
                {
                    contadorPalabras++;
                    enPalabra = false;
                }
            }
            else
            {
                // Si es cualquier otro carácter, estamos dentro de una palabra
                enPalabra = true;
            }
        }

        // Contar la última palabra si el texto no terminó en espacio/punto antes del $
        if (enPalabra)
        {
            contadorPalabras++;
        }

        Console.WriteLine($"\nNúmero de vocales: {contadorVocales}");
        Console.WriteLine($"Número de palabras: {contadorPalabras}");
    }
}