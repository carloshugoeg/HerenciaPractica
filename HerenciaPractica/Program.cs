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
    switch (option)
    {
        case "1":
            Console.WriteLine("\n----------------");
            Console.WriteLine("Agregar Computadora");
            Console.Write("\nIngrese Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Año de lanzamiento: ");
            int year = AskInt();
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
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("EL numero es demasiado grande");
        Console.ReadLine();
        Console.Clear();
    }
    catch (Exception ex)
    {
        Console.WriteLine("ERROR");
        Console.WriteLine(ex.Message);
        Console.ReadLine();
        Console.Clear();
    }
}


