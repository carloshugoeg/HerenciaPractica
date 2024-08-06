using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HerenciaPractica
{
    public class MobileDevice : ElectronicDevice
    {
        public MobileDevice(string name, string brand, int year, string discStorage, 
            string operativeSystem,string screenSize, int cameraMP, string chargingPort, 
            int batteryDuration) : base(name, brand, year, discStorage, operativeSystem)
        {
            ScreenSize = screenSize;
            CameraMP = cameraMP;
            ChargingPort = chargingPort;
            BatteryDuration = batteryDuration;
        }

        public string ScreenSize { get; set; }
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
        public override int SearchDevice(List<ElectronicDevice> electronicDevices)
        {
            return base.SearchDevice(electronicDevices);
        }
    }
}
