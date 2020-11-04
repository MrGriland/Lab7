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
    public class Transformer : Car, ISmart
    {
        private int iq;
        public int Iq{
            get => iq;
            set
            {
                if (value > 300 || value< 1)
                {
                    throw new TransformerException("Iq не может быть меньше 1 или больше 300", value);
    }
                else
                {
                    iq = value;
                }
            }
            }
        public Transformer(int wheels, int weight, double length, int maxspeed, int year, string name, Engine engine, int iq) : base(wheels, weight, length, maxspeed, year, name, engine)
        {
            Iq = iq;
        }
        public void Think()
        {

        }
        public void Analyze()
        {

        }
        void ISmart.Info()
        {
            Console.WriteLine($"Transformer {Name} have a {Maxspeed} max speed and {Year} year");
        }
        public override void Info()
        {
            Console.WriteLine($"Car {Name} have a {Maxspeed} max speed and {Year} year");
        }
        public override string ToString()
        {
            return $"Class about transformers";
        }
    }
}
