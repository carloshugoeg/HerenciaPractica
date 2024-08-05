using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPractica
{
    public class Computer : ElectronicDevice
    {
        public string Processor { get; set; }
        public string GraphicCard { get; set; }
        public int RAM { get; set; }
      
        public override void ShowDevice()
        {
            base.ShowDevice();
            Console.WriteLine("Procesador: " + Processor);
            Console.WriteLine("Tarjeta Grafica: " + GraphicCard);
            Console.WriteLine($"Memoria RAM: {RAM}GB");
            

        }
    }
}
