using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void StopCar();

namespace pz_9
{

    internal class Car
    {
        public int speedometer1;

        public event StopCar MyEvent;

        public void speed()
        {
            for (int i = 0; i < 201; i++)
            {
                speedometer1 = i;
                if (speedometer1 == 81)
                {
                    if (MyEvent != null)
                    {
                        MyEvent();
                    }
                }
                else if (speedometer1 == 121)
                {
                    if (MyEvent != null)
                    {
                        MyEvent();
                    }
                }
                Console.WriteLine($"{speedometer1} км/ч");

            }

        }

        
    }

        class Program
    {
        static void carname()
        { Console.WriteLine("Лада Granda"); }

        public class Patrolman
        {

            public void Danger()
            {
                Console.WriteLine("Пожалуйста, понизьте скорость до безопасного значения!");
            }
            public void OverDanger()
            {
                Console.WriteLine("Это было последнее предупреждение! Начинаем погоню!");
            }
        }
        static void Main(string[] args)
        {
            Car speedometer = new Car();
            Patrolman signal = new Patrolman();
            speedometer.MyEvent += signal.Danger;
            speedometer.speed();
            speedometer.MyEvent += signal.OverDanger;

        }
    }
}
