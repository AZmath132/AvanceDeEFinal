using System;
using Menu;

class Program
{
    static void Main()
    {
        GestorVentas a = new GestorVentas();
        int opcion;
        do
        {
            Console.Clear(); 
            Console.WriteLine("------------------------------"); 
            Console.WriteLine(" SISTEMA DE VENTAS VAGUIN XD "); 
            Console.WriteLine("------------------------------"); 
            Console.WriteLine("1 -> Registrar Producto"); 
            Console.WriteLine("2 -> Editar Producto"); 
            Console.WriteLine("3 -> Eliminar Producto");
            Console.WriteLine("4 -> Registrar Venta"); 
            Console.WriteLine("5 -> Listar Productos"); 
            Console.WriteLine("6 -> Listar Ventas"); 
            Console.WriteLine("7 -> Salir"); 
            Console.WriteLine("------------------------------");
            Console.Write("Ingrese un número del 1 al 7: "); 
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Registro de Producto");
                    a.RegistrarProducto();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Edición de Producto");
                    a.EditarProducto();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Eliminación de Producto");
                    a.EliminarProducto();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Registro de Venta");
                    a.RegistrarVenta();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Listado de Productos");
                    a.ListarProductos();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Listado de Ventas");
                    a.ListarVentas();
                    break;
                case 7:
                    Console.WriteLine("Gracias por usar el programa. ¡Hasta luego!");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opción no válida. Inténtalo nuevamente.");
                    break;
            }

            if (opcion != 7)
            {
                Console.WriteLine("\nPresiona cualquier tecla para regresar al menú principal...");
                Console.ReadKey();
            }
        } while (opcion != 7);
        Console.ReadKey();
    }
}

