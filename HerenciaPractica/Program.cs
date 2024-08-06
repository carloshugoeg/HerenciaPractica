using HerenciaPractica;
using System.Runtime.CompilerServices;

List<ElectronicDevice> electronicDevices = new List<ElectronicDevice>();
do
{
    Console.WriteLine("------TIENDA ELECTRONICA------");
    Console.WriteLine("\n     1. Agregar Dispositivo");
    Console.WriteLine("\n     2. Listar Productos");
    Console.WriteLine("\n     3. Buscar Productos");
    string opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            AddDevice(electronicDevices);
            break;
    }
}while (true);

void AddDevice(List<ElectronicDevice> electronicDevices)
{
    Console.Clear();
    Console.WriteLine("------Agregar Dispositivo-------");
    Console.WriteLine("\n     1. Computadora");
    Console.WriteLine("     2. Telefono");
    Console.WriteLine("     3. Tablet");
    string option = Console.ReadLine();
    Console.WriteLine("\n----------------");
    Console.Write("\nIngrese Nombre: ");
    string nombre = Console.ReadLine();
    Console.Write("Ingrese Marca: ");
    string marca = Console.ReadLine();
    int year;
    do
    {
        Console.Write("Año de lanzamiento: ");
        year = AskInt();
    } while (year == -1);
    Console.Write("Almacenamiento: ");
    string storage = Console.ReadLine();
    Console.Write("Sistema operativo: ");
    string os = Console.ReadLine();
    switch (option)
    {
        case "1":
           
            Console.WriteLine("Procesador: ");
            string procesor = Console.ReadLine();
            Console.WriteLine("Tarjeta Grafica: ");
            string graphicCard = Console.ReadLine();
            Console.WriteLine("RAM: ");
            string RAM = Console.ReadLine();
            Computer computer = new Computer(nombre, marca, year, storage, os, procesor, graphicCard, RAM);
            break;
        case "2":
            Console.WriteLine("Resolucion de pantalla: ");
            string screen = Console.ReadLine();
            int camera, battery;
            do
            {
                Console.Write("Megapixeles de camara: ");
                camera = AskInt();
            } while (camera == -1);
            Console.WriteLine("Puerto de carga: ");
            string charging = Console.ReadLine();
            do
            {
                Console.Write("Horas de bateria: ");
                battery = AskInt();
            } while (battery == -1);
            break;
    }

}

int AskInt()
{
    try
    {
        int number;
        do
        {
            number = int.Parse(Console.ReadLine());
            if (number == 0 || number == null)
            {
                Console.WriteLine("Valor no puede ser 0");
                Console.ReadLine();
            }
        } while (number == 0);
        return number;
    }
    catch (FormatException ex)
    {
        Console.WriteLine("INPUT INVALIDO");
        Console.WriteLine(ex.Message);
        Console.ReadLine();
        Console.Clear();
        return -1;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("EL numero es demasiado grande");
        Console.ReadLine();
        Console.Clear();
        return -1;
    }
    catch (Exception ex)
    {
        Console.WriteLine("ERROR");
        Console.WriteLine(ex.Message);
        Console.ReadLine();
        Console.Clear();
        return -1;
    }
}


