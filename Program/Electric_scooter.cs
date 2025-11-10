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
            Engine_power = engine_power;
            Load_capacity = load_capacity;
        }

        public int Engine_power
        {
            get { return engine_power; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Мощность двигателя не может быть отрицательной");
                if (value < 200 || value > 3000)
                    throw new ArgumentException("Мощность двигателя должна быть в диапазоне от 200 до 3000 Вт");
                engine_power = value;
            }
        }

        public float Load_capacity
        {
            get { return load_capacity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Грузоподъемность не может быть отрицательной");
                if (value < 50 || value > 300)
                    throw new ArgumentException("Грузоподъемность должна быть в диапазоне от 50 до 300 кг");
                load_capacity = value;
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Параметры электросамоката:");
            base.PrintInfo();
            Console.WriteLine($"Мощность двигателя (в Вт): {Engine_power}");
            Console.WriteLine($"Грузоподъемность (в кг): {Load_capacity}");
        }
    }
}
