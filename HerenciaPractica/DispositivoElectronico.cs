using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPractica
{
    public class ElectronicDevice
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public int DiscStorage { get; set; }
        public virtual void ShowDevice()
        {
            Console.WriteLine("\n\n--------------------------");
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine($"{Name}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------");
            Console.WriteLine($"\nMarca: {Brand}");
            Console.WriteLine($"Año: {Year}");
            Console.WriteLine($"Capacidad de Almacenamiento: {DiscStorage}GB");

        }
    }
}
