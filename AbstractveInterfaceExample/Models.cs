using AbstractveInterfaceExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractveInterfaceExample
{
    public abstract class Models : IColorsAndDecals
    {
        public void Colors()
        {
            Console.WriteLine("Model Siyah Rengindedir..");
        }

        public void Decals()
        {
            Console.WriteLine("Model Decalsizdir..");
        }

        public abstract void Go();

        public void Moving()
        {
            Console.WriteLine("Model Hareket Ediyor..");
        }
    }

    public class Car : Models , IProperties
    {
        public override void Go()
        {
            Console.WriteLine("Araba Harekete Başladı..");
        }
        public void CanTurnWheel()
        {
            Console.WriteLine("Arabanın Tekerleri Dönebiliyor..");
        }

        public void DoorCount()
        {
            Console.WriteLine("Arabanın 6 Kapısı Var..");
        }

        public void Size()
        {
            Console.WriteLine("Arabanın Ölçüsü 1/24 Oranındadır..");
        }

        public void WheelCount()
        {
            Console.WriteLine("Arabanın 4 Tekeri Var..");
        }
    }

    public class Motorcyle : Models , IProperties
    { 
        public override void Go()
        {
            Console.WriteLine("Motorsiklet Harekete Başladı..");
        }

        public void CanTurnWheel()
        {
            Console.WriteLine("Motorsikletin Tekerleri Dönemiyor..");
        }

        public void DoorCount()
        {
            Console.WriteLine("Motorsikletin 0 Kapısı Var..");
        }
        public void Size()
        {
            Console.WriteLine("Motorsikletin Ölçüsü 1/8 Oranındadır..");
        }

        public void WheelCount()
        {
            Console.WriteLine("Motorsikletin 2 Tekeri Var..");
        }
    }
}
