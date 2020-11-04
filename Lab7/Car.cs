using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace Lab5
{
    public class Car: Transport
    {
        private int maxspeed;
        public int Maxspeed
        {
            get { return maxspeed; }
            set
            {
                if (value > 450 || value < 100)
                {
                    throw new CarException("Маскимальная скорость автомобиля не может быть меньше 100 км/ч или больше 450км/ч", value);
                }
                else
                {
                    maxspeed = value;
                }
            }
        }

        private int year;
        public int Year
        {
            get => year;
            set => year = value;
        }

        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        private Engine engine;
        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public Car(int wheels, int weight, double length, int maxspeed, int year, string name, Engine engine): base(wheels, weight, length)
        {
            Maxspeed = maxspeed;
            Year = year;
            Name = name;
            Engine = engine;
        }
        public override void Info()
        {
            Console.WriteLine($"Car {Name} have a {Maxspeed} max speed and {Year} year");
        }
        public override string ToString()
        {
            return $"Class about car";
        }
    }
}
