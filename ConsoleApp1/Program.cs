using System;
using System.Collections.Generic;

namespace MainProj
{
    class Program
    {
        static void AppendElement(List<Vehicle> list)
        {
            Console.WriteLine("Объект какого вида вы хотите создать?");
            Console.WriteLine("1 - транспортное средство");
            Console.WriteLine("2 - электросамокат");
            Console.WriteLine("3 - легковой автомобиль");

            if (!int.TryParse(Console.ReadLine(), out int answer)) // Защита от некорректного ввода (является ли ввод числом)
            {
                throw new ArgumentException("Неверный ввод");
            }
            if (answer < 1 || answer > 3)
            {
                throw new ArgumentException("Неверный выбор");
            }

            if (answer == 1)
            {
                Console.Write("Введите фирму: ");
                string vendor = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(vendor))
                    throw new ArgumentException("Название производителя не может быть пустым");

                Console.Write("Введите цену (в рублях): ");
                if (!float.TryParse(Console.ReadLine(), out float price))
                    throw new ArgumentException("Неверный формат цены");

                list.Add(new Vehicle(vendor, price));
            }
            else if (answer == 2)
            {
                Console.Write("Введите фирму: ");
                string vendor = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(vendor))
                    throw new ArgumentException("Название производителя не может быть пустым");

                Console.Write("Введите мощность двигателя (Вт): ");
                if (!int.TryParse(Console.ReadLine(), out int enginePower))
                    throw new ArgumentException("Неверный формат мощности");
                Console.Write("Введите грузоподъемность (кг): ");
                if (!float.TryParse(Console.ReadLine(), out float loadCapacity))
                    throw new ArgumentException("Неверный формат грузоподъемности");
                Console.Write("Введите цену (в рублях): ");
                if (!float.TryParse(Console.ReadLine(), out float price))
                    throw new ArgumentException("Неверный формат цены");

                list.Add(new Electric_scooter(vendor, enginePower, loadCapacity, price));
            }
            else if (answer == 3)
            {
                Console.Write("Введите фирму: ");
                string vendor = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(vendor))
                    throw new ArgumentException("Название производителя не может быть пустым");

                Console.Write("Введите максимальную скорость (км/ч): ");
                if (!int.TryParse(Console.ReadLine(), out int maxSpeed))
                    throw new ArgumentException("Неверный формат скорости");
                Console.Write("Введите пассажировместимость: ");
                if (!int.TryParse(Console.ReadLine(), out int passengerCapacity))
                    throw new ArgumentException("Неверный формат пассажировместимости");
                Console.Write("Введите цену (в рублях): ");
                if (!float.TryParse(Console.ReadLine(), out float price))
                    throw new ArgumentException("Неверный формат цены");

                list.Add(new Passenger_car(vendor, maxSpeed, passengerCapacity, price));
            }
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Vehicle> list = new List<Vehicle>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - добавить элемент");
                Console.WriteLine("2 - вывести сведения об элементах");
                Console.WriteLine("3 - выйти");

                if (!int.TryParse(Console.ReadLine(), out int answer))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }

                

            }
        }
    }
}