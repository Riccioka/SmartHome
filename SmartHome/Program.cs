namespace SmartHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LightSystem light = new LightSystem();
            HeatingSystem heating = new HeatingSystem();
            SecuritySystem security = new SecuritySystem();

            Console.WriteLine("Добро пожаловать! (Clone)");

            bool work = true;

            while (work)
            {
                Console.WriteLine("СИСТЕМА УМНЫЙ ДОМ");
                Console.WriteLine("1 - Включить свет");
                Console.WriteLine("2 - Выключить свет");
                Console.WriteLine("3 - Показать температуру");
                Console.WriteLine("4 - Камера");
                Console.WriteLine("5 - Уведомление");
                Console.WriteLine("6 - Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        light.EnableLight();
                        break;

                    case "2":
                        light.DisableLight();
                        break;

                    case "3":
                        heating.ShowTemperature();
                        break;

                    case "4":
                        security.ShowCamera();
                        break;

                    case "5":
                        security.SendNotification();
                        break;

                    case "6":
                        work = false;
                        break;

                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}