using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaAlgoritmica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti ora:");

            var ora = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti minutele:");

            var minute = Convert.ToInt32(Console.ReadLine());


            if (minute == 0)
            {
                string traducereOra = TraducereOra(ora);
                Console.WriteLine($"este {traducereOra} fix ");
            }
            if (minute <= 30 && minute > 0)
            {
                Console.WriteLine(" {ora} si 30 min dupa ");
            }
            if (minute > 30)
            {
                Console.WriteLine(" {ora} si 30 min fara ");
            }


            Console.ReadKey();
        }

        public static string TraducereOra(int ore)
        {
            string traducere;
            switch (ore)
            {
                case 1:
                    traducere = "ora unu";
                    break;
                case 2:
                    traducere = "ora doi";
                    break;
                default:
                    traducere = "ora necunoscuta";
                    break;

            }
            return traducere;
        }
    }   
}
