using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class LightSystem
    {
        public bool LightStatus { get; set; }

        public void EnableLight()    
        {
            LightStatus = true;
            Console.WriteLine("Свет включен");
        }

        public void DisableLight()
        {
            LightStatus = false;
            Console.WriteLine("Свет выключен");
        }
    }
}