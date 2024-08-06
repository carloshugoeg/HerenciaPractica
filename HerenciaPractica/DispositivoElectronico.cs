using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPractica
{
    public class ElectronicDevice
    {
        public ElectronicDevice(string name, string brand, int year, int discStorage, string operativeSystem)
        {
            Name = name;
            Brand = brand;
            Year = year;
            DiscStorage = discStorage;
            OperativeSystem = operativeSystem;
        }

        public string Name { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public int DiscStorage { get; set; }
        public string OperativeSystem { get; set; }
        public virtual void ShowDevice()
        {
            Console.WriteLine("\n\n--------------------------");
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine($"{Name}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------");
            Console.WriteLine($"\nMarca: {Brand}");
            Console.WriteLine($"Sistema Operativo: {OperativeSystem}");
            Console.WriteLine($"Año: {Year}");
            Console.WriteLine($"Capacidad de Almacenamiento: {DiscStorage}GB");
        }

        public virtual int SearchDevice(List<ElectronicDevice> electronicDevices)
        {
            Console.WriteLine("¿Que desea buscar?: ");
            string deviceToSearch = Console.ReadLine();
            int index = 0;
            bool found = false;
            foreach (ElectronicDevice electronicDevice in electronicDevices)
            {
                if (electronicDevice.Name != deviceToSearch)
                {
                    index++;
                }
                else
                {
                    found = true;
                    break;
                }
            }
            if (found) return index;
            else return -1;
        }
    }
}
