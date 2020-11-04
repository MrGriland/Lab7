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
    public class Human: Driving, ISmart
    {
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        private string surname;
        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        private int dateyear;
        public int Dateyear
        {
            get => dateyear;
            set
            {
                if (value > 2020 || value < 1910)
                {
                    throw new HumanException("Дата рождения не может быть раньше 1910 года или позже 2020", value);
                }
                else
                {
                    dateyear = value;
                }
            }
        }

        public Human(string name,string surname, int dateyear)
        {
            Name = name;
            Surname = surname;
            Dateyear = dateyear;
        }
        public void Think()
        {

        }
        public void Analyze()
        {

        }
        public void Info()
        {
            Console.WriteLine($"Human {Name} {Surname} {Dateyear} year");
        }
        public override string ToString()
        {
            return $"Class about human";
        }
        public new void Start()
        {
            gear = 1;
        }
        public new void Stop()
        {
            gear = 0;
        }
        public new void TurnRight()
        {

        }
        public new void TurnLeft()
        {

        }
    }
}
