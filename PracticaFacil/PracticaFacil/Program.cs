using System;
using System.Numerics;
using System.Xml;

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
                Console.WriteLine("Opcion 4: Signo-Numero");
                Console.WriteLine("Opcion 5: Edad Check");
                Console.WriteLine("Opcion 6: Calculadora");
                Console.WriteLine("Opcion 0: Salir ");
                

                Console.WriteLine("Ingresa una opcion");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion) 
                {
                    case 1: ParImpar(); 
                            break;
                    case 2: NumeroMayor(); 
                        break;
                    case 3: AprovadoReprovado();
                        break;
                    case 4: SignoNumero();
                        break;
                    case 5: EdadCheck();
                        break;
                    case 6: Calculadora();
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
            
            void AprovadoReprovado()
            {
                Console.WriteLine("Ingresa un numero");

                int nota = 0;
                nota = int.Parse(Console.ReadLine());

                if (nota >= 60)
                {
                    Console.WriteLine("Usted ha sido aprovado");
                }
                else
                {
                    Console.WriteLine("Usted ha sido reprovado");
                }
            }
            
            void SignoNumero()
            {
                Console.WriteLine("Ingresa un numero");
                
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine(numero + "es un numero positivo");
                }
                else if (numero < 0)
                {
                    Console.WriteLine(numero + "es un numero negativo");
                }
                else
                {
                    Console.WriteLine("El numero ingresado es 0 ");
                }
            }

            void EdadCheck()
            {
                Console.WriteLine("Ingresa tu edad");
                
                int edad = int.Parse(Console.ReadLine());

                if (edad <= 0)
                {
                    Console.WriteLine("La edad ingresada es incorrecta");
                }

                else
                {
                    if (edad < 13)
                    {
                        Console.WriteLine("Eres un ninio ");
                    }
                    else if (edad < 18)
                    {
                        Console.WriteLine("Eres un adolecente ");
                    }
                    else if (edad < 66)
                    {
                        Console.WriteLine("Eres un adulto");
                    
                    }
                    else
                    {
                        Console.WriteLine("Eres un adulto mayor");
                    }
                }
            }

            void Calculadora()

            {
                int opcion = -1;
                while (opcion != 0)
                {
                    Console.WriteLine("***MENU***");
                    Console.WriteLine("1. SUMA");
                    Console.WriteLine("2. RESTA");
                    Console.WriteLine("3. MULTIPLICACION");
                    Console.WriteLine("4. DIVISION");
                    Console.WriteLine("0. SALIR");
                    
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1: Suma(); 
                            break;
                        case 2: Resta();
                            break;
                        case 3: Multiplicacion();
                            break; 
                        case 4: Division();
                            break;
                        default: Console.WriteLine("La opcion seleccionada no existe");
                            break;
                    }

                    void Suma()
                    {
                        Console.WriteLine("Escribe el primer numero a sumar");
                        int a = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Escribe el segundo numero a sumar");
                        int b = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("La suma de " +a +" + " +b + " es: " + (a +b));
                        
                    }

                    void Resta()
                    {
                        Console.WriteLine("Escribe el primer numero a Restar");
                        int a = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Escribe el segundo numero a Restar");
                        int b = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("La Resta de " +a +" - " +b + " es: " + (a -b));
                        
                    }

                    void Multiplicacion()
                    {
                        Console.WriteLine("Escribe el primer numero a multiplicar");
                        int a = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Escribe el segundo numero a multiplicar");
                        int b = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("La Multiplicacion de " +a +" * " +b + " es: " + (a *b));
                    }

                    void Division()
                    {
                        Console.WriteLine("Escribe el primer numero a Dividir");
                        int a = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Escribe el segundo numero a Dividir");
                        int b = int.Parse(Console.ReadLine());


                        if (b == 0)
                        {
                            Console.WriteLine("La division entre 0 es indefinida");
                        }
                        else
                        {
                        double resul = a / b;
                            
                            Console.WriteLine("La Division de " +a +" / " +b + " es: " + resul);

                        }
                    }
                    
                    
                }
                
                
            }
            
        }
    }
}