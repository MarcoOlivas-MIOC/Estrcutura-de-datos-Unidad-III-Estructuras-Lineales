using System;

namespace Proyecto3_Llamadas
{
    internal class Program
    {
        static Pila llamadas = new Pila();

        static void Main()
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("=== SIMULADOR DE LLAMADAS ===");
                Console.WriteLine("1. Registrar llamada");
                Console.WriteLine("2. Regresar / Atender / Finalizar");
                Console.WriteLine("3. Mostrar historial / Llamadas activas");
                Console.WriteLine("4. Recuperar última llamada");
                Console.WriteLine("5. Buscar llamada");
                Console.WriteLine("6. Eliminar llamada");
                Console.WriteLine("7. Registrar Cliente");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Función: ");
                        llamadas.Apilar(Console.ReadLine());
                        break;

                    case 2:
                        string llamada = llamadas.Desapilar();

                        Console.WriteLine(
                            llamada == null
                            ? "No existen llamadas."
                            : $"Regresando de {llamada}");

                        Console.ReadKey();
                        break;

                    case 3:
                        llamadas.Mostrar();
                        Console.ReadKey();
                        break;

                    case 4:
                        string ultima = llamadas.RecuperarUltimaLlamada();
                        Console.WriteLine(
                            ultima == null
                            ? "No existen llamadas."
                            : $"Última llamada: {ultima}");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Write("Llamada a buscar: ");
                        bool encontrada = llamadas.BuscarLlamada(Console.ReadLine());
                        Console.WriteLine(encontrada ? "Llamada encontrada." : "No se encontró.");
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Write("Llamada a eliminar: ");
                        bool eliminada = llamadas.EliminarLlamada(Console.ReadLine());
                        Console.WriteLine(eliminada ? "Llamada eliminada." : "No se encontró.");
                        Console.ReadKey();
                        break;

                    case 7:
                        Console.Write("Nombre del cliente: ");
                        llamadas.RegistrarCliente(Console.ReadLine());
                        break;
                }

            } while (opcion != 0);
        }
    }
}