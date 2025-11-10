using System;

namespace MainProj
{
    public class Passenger_car : Vehicle
    {
        private int max_speed;
        private int passenger_capacity;

        public Passenger_car(string vendor, int max_speed, int passenger_capacity, float price) 
            : base(vendor, price)
        {
            // свойства для валидации
            Max_speed = max_speed;
            Passenger_capacity = passenger_capacity;
        }

        public int Max_speed
        {
            get { return max_speed; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Максимальная скорость не может быть отрицательной");
                if (value < 40 || value > 360)
                    throw new ArgumentException("Максимальная скорость должна быть в диапазоне от 40 до 360 км/ч");
                max_speed = value;
            }
        }

        public int Passenger_capacity
        {
            get { return passenger_capacity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Пассажировместимость не может быть отрицательной");
                if (value < 2 || value > 16)
                    throw new ArgumentException("Пассажировместимость должна быть в диапазоне от 2 до 16 человек");
                passenger_capacity = value;
            }
        }

       
    }
}
