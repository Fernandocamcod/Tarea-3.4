using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la calificación numérica del estudiante (0-10): ");
        double calificacion = Convert.ToDouble(Console.ReadLine());

        // Variable para almacenar la letra equivalente
        char letraCalificacion;

        // Clasificación de la calificación
        switch (calificacion)
        {
            case double n when (n >= 9 && n <= 10):
                letraCalificacion = 'A';
                break;
            case double n when (n >= 8 && n < 9):
                letraCalificacion = 'B';
                break;
            case double n when (n >= 7 && n < 8):
                letraCalificacion = 'C';
                break;
            case double n when (n >= 6 && n < 7):
                letraCalificacion = 'D';
                break;
            case double n when (n >= 0 && n < 6):
                letraCalificacion = 'F';
                break;
            default:
                Console.WriteLine("Calificación no válida. Debe estar entre 0 y 10.");
                return; // Salir del programa si la calificación es inválida
        }

        // Mostrar el resultado
        Console.WriteLine($"La letra equivalente de la calificación {calificacion} es: {letraCalificacion}");

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}
