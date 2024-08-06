using HerenciaPractica;
using System.Runtime.CompilerServices;

List<ElectronicDevice> electronicDevices = new List<ElectronicDevice>();
ElectronicDevice electronicDevice = new ElectronicDevice("", "", -1, "", "");
do
{
    Console.Clear();
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
        case "2":
            foreach (var device in electronicDevices)
            {
                device.ShowDevice();
            }
            Console.Write("Presione ENTER para continuar");
            Console.ReadLine();
            break;

        case "3":
            int index = electronicDevice.SearchDevice(electronicDevices);
            if(index != -1)
            {
                electronicDevices[index].ShowDevice();
            }
            else Console.WriteLine("Dicho dispositivo no existe");
            Console.Write("Presione ENTER para continuar");
            Console.ReadLine();
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
           
            Console.Write("Procesador: ");
            string procesor = Console.ReadLine();
            Console.Write("Tarjeta Grafica: ");
            string graphicCard = Console.ReadLine();
            Console.Write("RAM: ");
            string RAM = Console.ReadLine();
            Computer computer = new Computer(nombre, marca, year, storage, os, procesor, graphicCard, RAM);
            electronicDevices.Add(computer);
            Console.Write("Objeto agregado correctamente");
            Console.ReadLine();
            break;
        case "2":
            Console.Write("Resolucion de pantalla: ");
            string screen = Console.ReadLine();
            int camera, battery, sim;
            do
            {
                Console.Write("Megapixeles de camara: ");
                camera = AskInt();
            } while (camera == -1);
            Console.Write("Puerto de carga: ");
            string charging = Console.ReadLine();
            do
            {
                Console.Write("Horas de bateria: ");
                battery = AskInt();
            } while (battery == -1);
            do
            {
                Console.Write("Espacios de SIM: ");
                sim = AskInt();
            } while (sim == -1);
            Console.Write("Ancho de banda: ");
            string bandwith = Console.ReadLine();
            Phone phone = new Phone(nombre, marca, year, storage, os, screen, camera, charging, battery, sim, bandwith);
            electronicDevices.Add(phone);
            Console.Write("Objeto agregado correctamente");
            Console.ReadLine();
            break;
        case "3":
            Console.Write("Resolucion de pantalla: ");
            string screenSize = Console.ReadLine();
            int cameraMp, batteryDuration;
            bool acceptsPencil, acceptsKeyboard;
            do
            {
                Console.Write("Megapixeles de camara: ");
                cameraMp = AskInt();
            } while (cameraMp == -1);
            Console.Write("Puerto de carga: ");
            string chargingPort = Console.ReadLine();
            do
            {
                Console.Write("Horas de bateria: ");
                batteryDuration = AskInt();
            } while (batteryDuration == -1);
            Console.Write("Acepta lapiz: s/n   ");
            string sn = Console.ReadLine().ToLower().Trim();
            if (sn == "s") acceptsPencil = true;
            else acceptsPencil = false;
            Console.Write("Acepta teclado: s/n   ");
            sn = Console.ReadLine().ToLower().Trim();
            if (sn == "s") acceptsKeyboard = true;
            else acceptsKeyboard = false;
            Tablet tablet = new Tablet(nombre, marca, year, storage, os, screenSize, cameraMp, chargingPort, batteryDuration, acceptsPencil, acceptsKeyboard);
            electronicDevices.Add(tablet);
            Console.Write("Objeto agregado correctamente");
            Console.ReadLine();
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


