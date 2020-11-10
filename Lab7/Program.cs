using Lab6;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Diagnostics;

namespace Lab5
{
    public class CarException : Exception
    {
        public CarException(string message, int maxspeed)
            : base(message)
        {
            Console.WriteLine($"Вы указали максимальную скорость {maxspeed} км/ч");
        }
    }
    public class HumanException : Exception
    {
        public HumanException(string message, int dateyear)
            : base(message)
        {
            Console.WriteLine($"Вы указали год рождения {dateyear}");
        }
    }
    public class TransformerException : Exception
    {
        public TransformerException(string message, int iq)
            : base(message)
        {
            Console.WriteLine($"Вы указали iq {iq}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine("diesel", 167, 7.1, 2.4);
            try
            {
                try { Car car1 = new Car(4, 1222, 3.5, 99, 2004, "Volvo v60", engine); }
                catch (CarException ex) { Console.WriteLine("Ошибка: " + ex.Message); }


                try { Car car1 = new Car(4, 1222, 3.5, 456, 2004, "Volvo v60", engine); }
                catch (CarException ex) { Console.WriteLine("Ошибка: " + ex.Message); }


                try { Human human = new Human("Grisha", "Bulgak", 1900); }
                catch (HumanException ex) { Console.WriteLine("Ошибка: " + ex.Message); }


                try { Human human1 = new Human("Grisha", "Bulgak", 2021); }
                catch (HumanException ex) { Console.WriteLine("Ошибка: " + ex.Message); }


                try { Transformer transformer = new Transformer(4, 3000, 4.4, 366, 2017, "Range Rover", engine, 0); }
                catch (TransformerException ex) { Console.WriteLine("Ошибка: " + ex.Message); }

                Car car3 = new Car(4, 1222, 3.5, 55, 2004, "Volvo v60", engine);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Исключение: " + ex.Message);
                Console.WriteLine($"Исключение было вызвано в следующем месте: {ex.InnerException}");
                Console.WriteLine($"{ex.StackTrace}");
            }
            catch
            {
                Console.WriteLine($"Универсальный обработчик\n");
            }
            finally
            {
                int index;
                index = -10;
                Debug.Assert(index > 0, "Индекс массива должен быть больше или 0!");
                Console.WriteLine($"Выполнение программы завершено!");
            }
        }
    }
}
// 4 7 9