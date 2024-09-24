using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AbstractveInterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Go();
            car.Moving();
            car.Size();
            car.DoorCount();
            car.WheelCount();
            car.CanTurnWheel();
            car.Colors();

            Console.WriteLine("***");

            Motorcyle motorcyle = new Motorcyle();

            motorcyle.Go();
            motorcyle.Moving();
            motorcyle.Size();
            motorcyle.DoorCount();
            motorcyle.WheelCount();
            motorcyle.CanTurnWheel();
            motorcyle.Decals();
        }
    }
}