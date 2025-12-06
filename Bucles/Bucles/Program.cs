using System;

namespace Bucles
{
    class Program
    {
        static void Main()
        {
            // SumaNumeros();
            //Factorial();
            // CuentaRegreseiva();
            // SumaPares();
            //TablaMulti();
            SumaDigitos();

        }

        static void SumaNumeros()
        {
            // Suma 1..N
            int N = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 1; i <= N; i++)
            {
                suma += i;
            }

            Console.WriteLine(suma);
        }

        static void Factorial()
        {

            Console.WriteLine("Ingresa el numero a convertir a factorial");
            long res = 1;

            long num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                res *= i;
            }
            Console.WriteLine("El factorial de " + num + " es " + res);

        }


        static void CuentaRegreseiva()
        {
            int cuenta = int.Parse(Console.ReadLine());

            int res = 0;

            do
            {
                Console.WriteLine(cuenta);

                cuenta--;
            }
            while (cuenta > 1);
        }

        static void SumaPares()
        {
            Console.WriteLine("Ingresa un numero a sumar");

            int res = 0;

            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    res = res + i;
                    Console.WriteLine(res);
                }
            }
        }

        static void TablaMulti()
        {
            Console.WriteLine("Ingresa el numero de la tabla de multiplicar");

            int n = int.Parse(Console.ReadLine());
            int limit = 12;


            for (int i = 1; i <= limit; i++)
            {
                int table = i * n;
                Console.WriteLine(i + " * " + n + " = " + table);
            }
        }

        static void SumaDigitos()
        {
            Console.WriteLine("Ingresa un numero");

            int n = int.Parse(Console.ReadLine());

            int suma = 0;

            while (n > 0)
            {
                int digito = n % 10;

                suma += digito;

                n = n / 10;
            }

            Console.WriteLine("La suma de los dígitos es: " + suma);

        }
    }
}





