using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPractica
{
    public class MobileDevice : ElectronicDevice
    {
        public double ScreenSize { get; set; }
        public int CameraMP {  get; set; }
        public string ChargingPort { get; set; }
        public int BatteryDuration { get; set; }
        public override void ShowDevice()
        {
            base.ShowDevice();
            Console.WriteLine($"Tamaño de pantalla: {ScreenSize}in");
            Console.WriteLine($"Calidad de camara:{CameraMP} Megapixeles");
            Console.WriteLine($"Puerto de Carga: Tipo {ChargingPort}");
            Console.WriteLine($"Duracion de bateria: {BatteryDuration} horas");
        }
    }
}
