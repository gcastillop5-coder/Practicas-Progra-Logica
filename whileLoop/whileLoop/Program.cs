using System;

class Program {
    static void Main() {
        // 1. Variable para guardar la suma total (La alcancía)
        int total = 0;

        // 2. Variable para leer lo que escribe el usuario. 
        // La iniciamos en -1 solo para garantizar que entre al bucle la primera vez.
        int venta = -1; 

        Console.WriteLine("Bienvenido al sistema de ventas.");

        // 3. El bucle: Mientras venta sea DISTINTO (!=) de 0...
        while (venta != 0) {
            Console.Write("Ingresa monto de venta (0 para salir): ");
            
            // A. Lee el número y guárdalo en la variable 'venta'
            venta = int.Parse(Console.ReadLine());
            
            // B. Suma esa venta al total (El acumulador)
            total = total + venta;
        }

        // 4. Al final, mostramos el resultado
        Console.WriteLine("El total de ventas del día es: " + total);
    }
}