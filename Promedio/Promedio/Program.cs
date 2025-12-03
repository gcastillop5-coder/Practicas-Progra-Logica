using System;

class Program
{
    static void Main()
    {
        int total = 0;
        int contador = 0;
        int venta = -1;

        while (venta != 0)
        {
            Console.Write("Ingresa venta (0 salir): ");
            venta = int.Parse(Console.ReadLine());

            if (venta != 0)
            {
                total = total + venta;
                contador++;
            }
        }

        Console.WriteLine("----- RESULTADOS -----");
        Console.WriteLine("Total Vendido: " + total);
        Console.WriteLine("Clientes Atendidos: " + contador);

        // --- TU MISIÓN ESTÁ AQUÍ ---

        // 1. Escribe un IF para verificar que el contador sea mayor a 0
        if (contador > 0)
        {

            // 2. Calcula el promedio. 
            // TRUCO: Multiplica 'total' por 1.0 para convertirlo temporalmente en decimal
            // y que la división te de decimales correctos.
            double promedio = (total * 1.0) / contador;

            Console.WriteLine("El promedio de venta es: " + promedio);
        }
        else
        {
            Console.WriteLine("No hubo ventas, no se puede calcular el promedio.");
        }
    }
}