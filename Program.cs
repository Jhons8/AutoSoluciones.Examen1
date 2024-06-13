using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoSoluciones.Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gestion_Clientes gestionClientes = new Gestion_Clientes();
            int opcion;

            do
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1 - Añadir cliente");
                Console.WriteLine("2 - Modificar cliente");
                Console.WriteLine("3 - Eliminar cliente");
                Console.WriteLine("4 - Consultar clientes");
                Console.WriteLine("5 - Salir");
                Console.Write("Opción: ");

                // Capturar y validar la opción del usuario
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    continue;
                }

                switch (opcion) // para evaluar
                {
                    case 1:
                        gestionClientes.Añadir();
                        break;
                    case 2:
                        gestionClientes.Modificar();
                        break;
                    case 3:
                        gestionClientes.Eliminar();
                        break;
                    case 4:
                        gestionClientes.Consultar();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 5);
        }
    }
}