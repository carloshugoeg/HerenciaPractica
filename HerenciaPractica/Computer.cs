using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPractica
{
    public class Computer : ElectronicDevice
    {
        public Computer(string name, string brand, int year, string discStorage, 
            string operativeSystem,string processor, string graphicCard, string rAM)
            : base (name, brand, year, discStorage, operativeSystem)
        {
            Processor = processor;
            GraphicCard = graphicCard;
            RAM = rAM;
        }

        public string Processor { get; set; }
        public string GraphicCard { get; set; }
        public string RAM { get; set; }
      
        public override void ShowDevice()
        {
            base.ShowDevice();
            Console.WriteLine("Procesador: " + Processor);
            Console.WriteLine("Tarjeta Grafica: " + GraphicCard);
            Console.WriteLine($"Memoria RAM: {RAM}GB");
        }
        public override int SearchDevice(List<ElectronicDevice> electronicDevices)
        {
            return base.SearchDevice(electronicDevices);
        }
    }
}
