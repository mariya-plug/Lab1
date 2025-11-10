using System;

namespace MainProj
{
    public class Electric_scooter : Vehicle
    {
        private int engine_power;
        private float load_capacity;

        public Electric_scooter(string vendor, int engine_power, float load_capacity, float price) // Убрали ?
            : base(vendor, price)
        {
            // свойства для валидации
            engine_power = engine_power;
            load_capacity = load_capacity;
        }

       
        public override void PrintInfo()
        {
            Console.WriteLine("Параметры электросамоката:");
            base.PrintInfo();
            Console.WriteLine($"Мощность двигателя (в Вт): {engine_power}");
            Console.WriteLine($"Грузоподъемность (в кг): {load_capacity}");
        }
    }
}
