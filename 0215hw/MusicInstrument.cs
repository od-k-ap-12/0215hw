using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215hw
{
    class MusicInstriment
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public MusicInstriment(string _Name, int _Year, double _Price)
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
        public virtual void History()
        {
            Console.WriteLine("History");
        }
        public virtual void Sound()
        {
            Console.WriteLine("Sound");
        }
    }
    class Violin : MusicInstriment
    {
        private static int Counter = 0;

        public Violin(string _Name, int _Year, double _Price) : base(_Name, _Year, _Price)
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
            Console.WriteLine("Violin");
        }
        public override void Desc()
        {
            Console.WriteLine("Violin Desc");
        }
        public override void History()
        {
            Console.WriteLine("Violin History");

        }
        public override void Sound()
        {
            Console.WriteLine("Violin Sound");
        }
    }
    class Trombone : MusicInstriment
    {
        private static int Counter = 0;

        public Trombone(string _Name, int _Year, double _Price) : base(_Name, _Year, _Price)
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
            Console.WriteLine("Trombone");
        }
        public override void Desc()
        {
            Console.WriteLine("Trombone Desc");
        }
        public override void History()
        {
            Console.WriteLine("Trombone History");
        }
        public override void Sound()
        {
            Console.WriteLine("Trombone Sound");
        }
    }

    class Ukulele : MusicInstriment
    {
        private static int Counter = 0;

        public Ukulele(string _Name, int _Year, double _Price) : base(_Name, _Year, _Price)
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
            Console.WriteLine("Ukulele");
        }
        public override void Desc()
        {
            Console.WriteLine("Ukulele Desc");
        }
        public override void History()
        {
            Console.WriteLine("Ukulele History");
        }
        public override void Sound()
        {
            Console.WriteLine("Ukulele Sound");
        }
    }
    class Cello : MusicInstriment
    {
        private static int Counter = 0;

        public Cello(string _Name, int _Year, double _Price) : base(_Name, _Year, _Price)
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
            Console.WriteLine("Cello");
        }
        public override void Desc()
        {
            Console.WriteLine("Cello Desc");
        }
        public override void History()
        {
            Console.WriteLine("Cello History");
        }
        public override void Sound()
        {
            Console.WriteLine("Cello Sound");
        }
    }
}
