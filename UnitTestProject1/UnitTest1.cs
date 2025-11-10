using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using MainProj;

namespace UnitTestProject1
{
    [TestClass]
    public class AllVehiclesTests
    {
        // Тесты для класса Vehicle
        [TestMethod]
        public void Vehicle_ValidData()
        {
            string vendor = "Toyota";
            float price = 1500000;
            var vehicle = new Vehicle(vendor, price);
            Assert.AreEqual(vendor, vehicle.Vendor);
            Assert.AreEqual(price, vehicle.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Vehicle_EmptyVendor()
        {
            new Vehicle("", 1500000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Vehicle_VendorWithDigits()
        {
            new Vehicle("Toyota123", 1500000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Vehicle_InvalidPrice()
        {
            new Vehicle("Toyota", 500);
        }

        // Тесты для класса Electric_scooter
        [TestMethod]
        public void ElectricScooter_ValidData()
        {
            var scooter = new Electric_scooter("Xiaomi", 500, 100, 30000);
            Assert.AreEqual("Xiaomi", scooter.Vendor);
            Assert.AreEqual(500, scooter.Engine_power);
            Assert.AreEqual(100, scooter.Load_capacity);
            Assert.AreEqual(30000, scooter.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ElectricScooter_InvalidEnginePower()
        {
            new Electric_scooter("Xiaomi", 100, 100, 30000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ElectricScooter_InvalidLoadCapacity()
        {
            new Electric_scooter("Xiaomi", 500, 20, 30000);
        }

        // Тесты для класса Passenger_car
        [TestMethod]
        public void PassengerCar_ValidData()
        {
            var car = new Passenger_car("Toyota", 200, 5, 1500000);
            Assert.AreEqual("Toyota", car.Vendor);
            Assert.AreEqual(200, car.Max_speed);
            Assert.AreEqual(5, car.Passenger_capacity);
            Assert.AreEqual(1500000, car.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PassengerCar_InvalidMaxSpeed()
        {
            new Passenger_car("Toyota", 20, 5, 1500000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PassengerCar_InvalidPassengerCapacity()
        {
            new Passenger_car("Toyota", 200, 1, 1500000);
        }

        // Тесты для методов вывода информации
        [TestMethod]
        public void Vehicle_PrintInfo()
        {
            string vendor = "Toyota";
            float price = 1500000;
            var vehicle = new Vehicle(vendor, price);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                vehicle.PrintInfo();

                string result = sw.ToString();
                Assert.IsTrue(result.Contains("Транспортное средство:"));
                Assert.IsTrue(result.Contains($"Производитель: {vendor}"));
                Assert.IsTrue(result.Contains($"Цена (в рублях): {price}"));
            }
        }

        [TestMethod]
        public void ElectricScooter_PrintInfo()
        {
            var scooter = new Electric_scooter("Xiaomi", 500, 100, 30000);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                scooter.PrintInfo();

                string result = sw.ToString();
                Assert.IsTrue(result.Contains("Параметры электросамоката:"));
                Assert.IsTrue(result.Contains("Производитель: Xiaomi"));
                Assert.IsTrue(result.Contains("Цена (в рублях): 30000"));
                Assert.IsTrue(result.Contains("Мощность двигателя (в Вт): 500"));
                Assert.IsTrue(result.Contains("Грузоподъемность (в кг): 100"));
            }
        }

        [TestMethod]
        public void PassengerCar_PrintInfo()
        {
            var car = new Passenger_car("Toyota", 200, 5, 1500000);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                car.PrintInfo();

                string result = sw.ToString();
                Assert.IsTrue(result.Contains("Параметры легкового автомобиля:"));
                Assert.IsTrue(result.Contains("Производитель: Toyota"));
                Assert.IsTrue(result.Contains("Цена (в рублях): 1500000"));
                Assert.IsTrue(result.Contains("Максимальная скорость (в км/ч): 200"));
                Assert.IsTrue(result.Contains("Пассажировместимость (в кол. человек): 5"));
            }
        }
    }
}