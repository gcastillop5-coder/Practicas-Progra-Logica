using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int opcion = -1;



            while (opcion != 0) 
            {
                Console.WriteLine("*****MENU*****");
                Console.WriteLine("Opcion 1: Par-Impar");
                Console.WriteLine("Opcion 2: Mayor de Tres ");
                Console.WriteLine("Opcion 3: Aprovado-Reprovado ");

                Console.WriteLine("Ingresa una opcion");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion) 
                {
                    case 1: ParImpar(); 
                            break;
                    case 2: NumeroMayor(); 
                        break;
                    default: Console.WriteLine("La opcion seleccionada no existe");
                        break;
                
                }


            }

            void  ParImpar()

            {
                int numero = 0;
                Console.WriteLine("Ingresa un numero");

                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("El numero Ingresado es Par");
                }
                else
                {
                    Console.WriteLine("El numero ingresado es impar");
                }
            }

            void NumeroMayor()

            {

                int numero1 = 0;
                Console.WriteLine("Ingresa el primer numero");
                numero1 = int.Parse(Console.ReadLine());

                int numero2 = 0;
                Console.WriteLine("Ingresa el segundo numero");
                numero2 = int.Parse(Console.ReadLine());

                int numero3 = 0;
                Console.WriteLine("Ingresa el tercer numero");
                numero3 = int.Parse(Console.ReadLine());

                int[] numeros = new int[3];


                numeros[0] = numero1;
                numeros[1] = numero2;
                numeros[2] = numero3;

                int maximo = numeros[0];
                for (int i = 1; i < numeros.Length; i++)
                {

                    if (numeros[i] > maximo)
                    { 
                        maximo = numeros[i];
                    }

                }
                Console.WriteLine("El numero mayor es: " + maximo);



            }
            
        }
    }
}