using System;
using System.Text.RegularExpressions;

namespace MainProj
{
    public class Vehicle
    {
        protected string vendor = string.Empty;
        protected float price;

        public Vehicle(string vendor, float price) 
        {
            if (string.IsNullOrWhiteSpace(vendor))
                throw new ArgumentException("Название производителя не может быть пустым");
            // свойства для валидации
            Vendor = vendor;
            Price = price;
        }

        public string Vendor
        {
            get { return vendor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Название производителя не может быть пустым");
                if (Regex.IsMatch(value, @"\d")) // Проверка на цифры в названии
                    throw new ArgumentException("Название производителя не должно содержать цифры");
                vendor = value;
            }
        }

        public float Price
        {
            get { return price; }
            set
            {
                if (value < 1000 || value > 10000000000)
                    throw new ArgumentException("Цена должна быть в диапазоне от 1000 до 10000000000 рублей");
                price = value;
            }
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Транспортное средство:");
            Console.WriteLine($"Производитель: {Vendor}");
            Console.WriteLine($"Цена (в рублях): {Price}");
        }
    }
}
