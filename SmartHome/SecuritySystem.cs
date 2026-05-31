using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class SecuritySystem
    {
        public void ShowCamera()
        {
            Console.WriteLine("Камера активна");
        }

        public void SendNotification()
        {
            Console.WriteLine("Обнаружено движение!");
        }
    }
}