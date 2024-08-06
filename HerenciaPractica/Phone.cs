using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPractica
{
    internal class Phone : MobileDevice
    {
        public Phone(string name, string brand, int year, string discStorage,
            string operativeSystem, string screenSize, int cameraMP, string chargingPort,
            int batteryDuration, int simSpots, string bandwith)
            : base(name, brand, year, discStorage, operativeSystem, screenSize, cameraMP, 
                  chargingPort, batteryDuration )
        {
            SimSpots = simSpots;
            Bandwith = bandwith;
        }

        public int SimSpots { get; set; }
        public string Bandwith {  get; set; }

        public override void ShowDevice()
        {
            base.ShowDevice();
            Console.WriteLine($"Cantidad de SIM: {SimSpots}");
            Console.WriteLine($"Ancho de Banda:{Bandwith}");
        }
        public override int SearchDevice(List<ElectronicDevice> electronicDevices)
        {
            return base.SearchDevice(electronicDevices);
        }

    }

}
