using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPractica
{
    internal class Tablet : MobileDevice
    {
        public Tablet(string name, string brand, int year, int discStorage,
            string operativeSystem, double screenSize, int cameraMP, string chargingPort,
            int batteryDuration, bool supportsPencil, bool supportsKeyboard)
            : base(name, brand, year, discStorage, operativeSystem, screenSize, cameraMP,
                  chargingPort, batteryDuration)
        {
            SupportsPencil = supportsPencil;
            SupportsKeyboard = supportsKeyboard;
        }

        public bool SupportsPencil { get; set; }
        public bool SupportsKeyboard { get; set; }
        public override void ShowDevice()
        {
            base.ShowDevice();
            Console.WriteLine($"Soporta Stylus: {SupportsPencil}");
            Console.WriteLine($"Soporta Teclado:{SupportsKeyboard}");
        }
        public override int SearchDevice(List<ElectronicDevice> electronicDevices)
        {
            return base.SearchDevice(electronicDevices);
        }
    }
}
