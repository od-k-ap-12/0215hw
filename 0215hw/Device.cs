using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215hw
{
    class Device
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public Device(string _Name, int _Year, double _Price)
        {
            Name = _Name;
            Year = _Year;
            Price = _Price;
        }
        public virtual void Print()
        {
            Console.WriteLine("Name: " + Name + "\nYear:" + Year + "\nPrice:" + Price);
        }
        public override string ToString()
        {
            return "Name: " + Name + "\nYear:" + Year + "\nPrice:" + Price;
        }
        public virtual void Show()
        {
            Console.WriteLine("Name");
        }
        public virtual void Desc()
        {
            Console.WriteLine("Desc");
        }
        public virtual void Sound()
        {
            Console.WriteLine("Sound");
        }
    }
    class Kettle : Device
    {
        private static int Counter = 0;

        public Kettle(string _Name, int _Year, double _Price) : base(_Name, _Year, _Price)
        {
            Counter++;
        }
        public override string ToString()
        {
            return base.ToString() + "Count: " + Counter + "\n";
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Count: " + Counter);
        }
        public override void Show()
        {
            Console.WriteLine("Kettle");
        }
        public override void Desc()
        {
            Console.WriteLine("Kettle Desc");
        }
        public override void Sound()
        {
            Console.WriteLine("Kettle Sound");
        }
    }
    class Microwave : Device
    {
        private static int Counter = 0;

        public Microwave(string _Name, int _Year, double _Price) : base(_Name, _Year, _Price)
        {
            Counter++;
        }
        public override string ToString()
        {
            return base.ToString() + "Count: " + Counter + "\n";
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Count: " + Counter);
        }
        public override void Show()
        {
            Console.WriteLine("Microwave");
        }
        public override void Desc()
        {
            Console.WriteLine("Microwave Desc");
        }
        public override void Sound()
        {
            Console.WriteLine("Microwave Sound");
        }
    }

    class Car : Device
    {
        private static int Counter = 0;

        public Car(string _Name, int _Year, double _Price) : base(_Name, _Year, _Price)
        {
            Counter++;
        }
        public override string ToString()
        {
            return base.ToString() + "Count: " + Counter + "\n";
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Count: " + Counter);
        }
        public override void Show()
        {
            Console.WriteLine("Car");
        }
        public override void Desc()
        {
            Console.WriteLine("Car Desc");
        }
        public override void Sound()
        {
            Console.WriteLine("Car Sound");
        }
    }
    class Steamboat : MusicInstriment
    {
        private static int Counter = 0;

        public Steamboat(string _Name, int _Year, double _Price) : base(_Name, _Year, _Price)
        {
            Counter++;
        }
        public override string ToString()
        {
            return base.ToString() + "Count: " + Counter + "\n";
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Count: " + Counter);
        }
        public override void Show()
        {
            Console.WriteLine("Steamboat");
        }
        public override void Desc()
        {
            Console.WriteLine("Steamboat Desc");
        }
        public override void Sound()
        {
            Console.WriteLine("Steamboat Sound");
        }
    }
}
