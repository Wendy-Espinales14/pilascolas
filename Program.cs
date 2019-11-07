using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace pilasycolas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                int auxiliar = 0;
                do
                {
                    Console.WriteLine("\n\n\t\t\tMenú ");
                    Console.WriteLine("\t\t\t 1- Pila");
                    Console.WriteLine("\t\t\t 2- Cola");
                    Console.WriteLine("\t\t\t 3- Reutilizacion");
                    Console.WriteLine("\t\t\t 4- Salir ");
                    Console.WriteLine("\t\t\tOpción: ");

                    int op = Convert.ToInt32(Console.ReadLine());

                    if (op == 1)
                    {
                        Stack pila = new Stack();
                        int opcion = 0;
                        do
                        {
                            opcion = Menu();
                            switch (opcion)
                            {
                                case 1:
                                    Añadir(ref pila);
                                    break;
                                case 2:
                                    Eliminar(ref pila);
                                    break;
                                case 3:
                                    Limpiar(ref pila);
                                    break;
                                case 4:
                                    Imprimir(pila);
                                    break;
                                case 5:
                                    break;
                                default:
                                    Console.WriteLine("opcion no valida");
                                    break;
                            }
                        } while (opcion != 5);

                        Console.WriteLine(" final del programa");

                        static void Añadir(ref Stack lapila)
                        {
                            Console.WriteLine("\n>Ingrese valor: ");
                            try
                            {
                                int numero = Convert.ToInt32(Console.ReadLine());
                                if (numero > 27 || numero <= 0)
                                {

                                    Console.WriteLine("Solo son permitidos numeros del 1 al 27");

                                }
                                else
                                {
                                    lapila.Push(numero);
                                    Imprimir(lapila);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Solo son permitidos numeros del 1 al 27");
                            }
                        }

                        static void Limpiar(ref Stack lapila)
                        {
                            lapila.Clear();
                            Imprimir(lapila);
                        }
                        static void Eliminar(ref Stack lapila)
                        {
                            if (lapila.Count > 0)
                            {
                                int numero = (int)lapila.Pop();
                                Console.WriteLine("dato" + numero + "eliminado");
                            }
                            else
                            {
                                Imprimir(lapila);
                            }
                        }
                        static int Menu()
                        {
                            Console.WriteLine(" \n               Menu\n");
                            Console.WriteLine(" 1.- Añadir elemento ");
                            Console.WriteLine(" 2.- Eliminar un elemento ");
                            Console.WriteLine(" 3.- Vacíar pila ");
                            Console.WriteLine(" 4.- Ver los elementos de la pila ");
                            Console.WriteLine(" 5.- Salir de la pila ");
                            Console.WriteLine(" > Ingresar nueva opcion: ");
                            try
                            {
                                int numero = Convert.ToInt32(Console.ReadLine());
                                return numero;
                            }
                            catch
                            {
                                return 0;
                            }
                        }
                        static void Imprimir(Stack lapila)
                        {

                            if (lapila.Count > 0)
                            {
                                Console.WriteLine(" ");
                                foreach (int auxi in lapila)
                                {
                                    Console.WriteLine("     |  |");
                                    if (auxi < 10)
                                    {
                                        Console.WriteLine(" |   0 {1}   |" + auxi);
                                    }
                                    else
                                    {
                                        Console.WriteLine(" |   0 {1}   |" + auxi);
                                        Console.WriteLine(" |  ------   |");
                                    }
                                }
                                Console.WriteLine("\nPresione cualquier tecla para continuar");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("----->>>>>  pila  vacia");
                            }
                        }
                        Console.WriteLine("Desea seguir usando la pila?");
                        Console.WriteLine("1.- Si");
                        Console.WriteLine("2.- No");
                        Console.WriteLine("Digite su opcion");
                        int op2 = Convert.ToInt32(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Menu();
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                    if (op == 2)
                    {
                        Queue cola = new Queue();
                        int opcion = 0;
                        do
                        {
                            opcion = Menu();
                            switch (opcion)
                            {
                                case 1:
                                    Añadir(ref cola);
                                    break;
                                case 2:
                                    Eliminar(ref cola);
                                    break;
                                case 3:
                                    Limpiar(ref cola);
                                    break;
                                case 4:
                                    Imprimir(cola);
                                    break;
                                case 5:
                                    break;
                                default:
                                    Console.WriteLine("ERROR: intente digitando otra opción");
                                    break;
                            }

                        } while (opcion != 5);

                        Console.WriteLine("El programa ha finalizado");

                        static void Añadir(ref Queue lacola)
                        {
                            Console.WriteLine("\n>Ingrese valor: ");

                            try
                            {
                                int numero = Convert.ToInt32(Console.ReadLine());

                                if (numero > 104 || numero <= 0)
                                {

                                    Console.WriteLine("Solo son permitidos numeros del 1 al 104");

                                }
                                else
                                {
                                    lacola.Enqueue(numero);
                                    Imprimir(lacola);
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Error: Solo son permitidos numeros del 1 al 104");
                            }
                        }
                        static void Limpiar(ref Queue lacola)
                        {
                            lacola.Clear();
                            Imprimir(lacola);
                        }

                        static void Eliminar(ref Queue lacola)
                        {
                            int numero = (int)lacola.Dequeue();
                            Console.WriteLine("Elemento" + numero + "eliminado");

                            Imprimir(lacola);

                        }
                        static int Menu()
                        {
                            Console.WriteLine(" \n              Stack Menu\n");
                            Console.WriteLine(" 1.- Añadir ");
                            Console.WriteLine(" 2.- Eliminar Elemento ");
                            Console.WriteLine(" 3.- Vacíar ");
                            Console.WriteLine(" 4.- Ver elementos de la cola ");
                            Console.WriteLine(" 5.- Salir ");
                            Console.WriteLine(" > Ingresar opcion: ");

                            try
                            {
                                int numero = Convert.ToInt32(Console.ReadLine());
                                return numero;
                            }
                            catch
                            {
                                return 0;
                            }
                        }
                        static void Imprimir(Queue lacola)
                        {

                            if (lacola.Count > 0)
                            {
                                Console.WriteLine(" ");
                                foreach (int auxi in lacola)
                                {
                                    Console.WriteLine("     |  |");
                                    if (auxi < 10)
                                    {
                                        Console.WriteLine(" |   0 {1}   |" + auxi);
                                    }
                                    else
                                    {
                                        Console.WriteLine(" |   0 {1}   |" + auxi);
                                        Console.WriteLine(" |  ------   |");
                                    }
                                }
                                Console.WriteLine("\nPresione una tecla para continuar");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine(".... cola vacia.....");
                            }
                            Console.ReadLine();
                        }
                        Console.WriteLine("Desea seguir usando la cola?");
                        Console.WriteLine("1.- Si");
                        Console.WriteLine("2.- No");
                        Console.WriteLine("igrese opcion");
                        int op2 = Convert.ToInt32(Console.ReadLine());
                        if (op2 == 1)
                        {
                            Menu();
                        }
                        else
                        {
                            Console.Clear();
                        }
                    }
                    if (op == 3)
                    {
                    }
                    if (op == 4)
                    {
                        Console.ReadKey();
                        auxiliar = 1;
                    }
                } while (auxiliar == 0);
                Console.ReadLine();
            }
        }
    }

