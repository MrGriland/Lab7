using Lab6;
using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task_5
            Engine engine = new Engine("diesel", 167, 7.1, 2.4);
            Car car = new Car(4, 1222, 3.5, 210, 2004, "Volvo v60", engine);
            car.Info();

            if (car is Transport) Console.WriteLine("Объект car принадлежит классу Transport.\n");
            else Console.WriteLine("Объект car не принадлежит классу Transport.\n");

            Human human = new Human("Grisha", "Bulgak", 2002);
            human.Info();
            Engine engine1 = new Engine("diesel", 167, 7.1, 2.4);
            Transformer transformer = new Transformer(4, 1700, 3.6, 250, 2016, "Range Rover", engine1);
            transformer.Info();

            if (transformer is Transport) Console.WriteLine("Объект transformer принадлежит классу Transport.\n");
            else Console.WriteLine("Объект transformer не принадлежит классу Transport.\n");

            if (human is Driving) Console.WriteLine("Объект human принадлежит классу Driving.\n");
            else Console.WriteLine("Объект human не принадлежит классу Driving.\n");

            Transport car_copy = car as Transport;
            Console.WriteLine(car_copy.ToString());
            #endregion

            #region task_6
            Car car1 = new Car(4, 1222, 3.5, 210, 2004, "Volvo v60", new Engine("petrol", 320, 8, 3.2));
            Transformer transformer1 = new Transformer(4, 1222, 3.1, 230, 2018, "Volvo v40", new Engine("petrol", 320, 8.6, 3.0));
            Printer printer = new Printer();
            ISmart transformer3 = new Transformer(4, 1400, 3.4, 214, 2013, "Toyota Corolla", new Engine("petrol", 190, 7, 1.8));
            transformer3.Info();
            Transport[] transports = new Transport[] { car1, transformer1 };
            Console.WriteLine();
            foreach (var item in transports)
            {
                printer.IAmPrinting(item);
                Console.WriteLine();
            }
            #endregion

            Troop troop1 = new Troop(TroopType.Human, 200, 2002, "medium");
            Troop troop2 = new Troop(TroopType.Transformer, 300, 2014, "medium");
            Troop troop3 = new Troop(TroopType.Transformer, 1000, 2019, "maximal");
            Troop troop4 = new Troop(TroopType.Human, 100, 1999, "minimal");
            Army army = new Army(troop1, troop2, troop3, troop4);
            army.Print();
            army.DateFind();
            army.TransformerPowerFind();
            army.Count();
        }
    }
}
