using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class HeatingSystem
    {
        public int Temperature { get; set; } = 23;

        public void ShowTemperature()
        {
            Console.WriteLine($"Температура: {Temperature}°C");
        }

        public void SetTemperature(int temp)
        {
            Temperature = temp;
            Console.WriteLine("Температура изменена");
        }
    }
}