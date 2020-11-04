using System;
namespace Lab5
{
    public class Printer
    {

        virtual public void IAmPrinting(Transport obj)
        {
            if (obj is Car)
            {
                Console.WriteLine(obj.ToString()); ;
            }
            else if (obj is Transformer)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}
