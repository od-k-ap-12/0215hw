using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215hw
{
    class Money
    {
        public int Mode;
        public uint Dollar;
        public uint Euro;
        public uint Hryvnia;
        public uint Cent;
        public uint Eurocent;
        public uint Kopiyka;
        public Money(int _Mode, uint _CurrencyNote, uint _CurrencyCoin)
        {
            Mode = _Mode;
            switch (_Mode)
            {
                case 1:
                    Dollar = _CurrencyNote;
                    Cent = _CurrencyCoin;
                    break;
                case 2:
                    Euro = _CurrencyNote;
                    Eurocent = _CurrencyCoin;
                    break;
                case 3:
                    Hryvnia = _CurrencyNote;
                    Kopiyka = _CurrencyCoin;
                    break;
                default:
                    throw new Exception("Invalid Mode");
                    break;
            }
        }
        public uint _Dollar
        {
            get
            {
                if (Mode != 1)
                {
                    throw new Exception("Invalid Mode");
                }
                else
                {
                    return Dollar;
                }
            }
            set
            {
                if (Mode != 1)
                {
                    throw new Exception("Invalid Mode");
                }
                else
                {
                    Dollar = value;
                }
            }
        }
        public uint _Cent
        {
            get
            {
                if (Mode != 1)
                {
                    throw new Exception("Invalid Mode");
                }
                else
                {
                    return Cent;
                }
            }
            set
            {
                if (Mode != 1)
                {
                    throw new Exception("Invalid Mode");
                }
                else
                {
                    Cent = value;
                }
            }
        }
        public uint _Euro
        {
            get
            {
                if (Mode != 2)
                {
                    throw new Exception("Invalid Mode");
                }
                else
                {
                    return Euro;
                }
            }
            set
            {
                if (Mode != 2)
                {
                    throw new Exception("Invalid Mode");
                }
                else
                {
                    Euro = value;
                }
            }
        }
        public uint _Eurocent
        {
            get
            {
                if (Mode != 2)
                {
                    throw new Exception("Invalid Mode");
                }
                else
                {
                    return Eurocent;
                }
            }
            set
            {
                if (Mode != 2)
                {
                    throw new Exception("Invalid Mode");
                }
                else
                {
                    Eurocent = value;
                }
            }
        }
        public uint _Hryvnia
        {
            get
            {
                if (Mode != 3)
                {
                    throw new Exception("Invalid Mode");
                }
                else
                {
                    return Hryvnia;
                }
            }
            set
            {
                if (Mode != 3)
                {
                    throw new Exception("Invalid Mode");
                }
                else
                {
                    Hryvnia = value;
                }
            }
        }
        public uint _Kopiyka
        {
            get
            {
                if (Mode != 3)
                {
                    throw new Exception("Invalid Mode");
                }
                else
                {
                    return Kopiyka;
                }
            }
            set
            {
                if (Mode != 3)
                {
                    throw new Exception("Invalid Mode");
                }
                else
                {
                    Kopiyka = value;
                }
            }
        }
        public virtual void Print()
        {
            switch (Mode)
            {
                case 1:
                    Console.WriteLine("Dollars: " + Dollar + "\nCents: " + Cent);
                    break;
                case 2:
                    Console.WriteLine("Euros: " + Euro + "\nEurocents: " + Eurocent);
                    break;
                case 3:
                    Console.WriteLine("Hryvnias: " + Hryvnia + "\nKopiykas: " + Kopiyka);
                    break;
                default:
                    break;
            }
        }
        public override string ToString()
        {
            switch (Mode)
            {
                case 1:
                    return "Dollars: " + Dollar + "\nCents: " + Cent;
                    break;
                case 2:
                    return "Euros: " + Euro + "\nEurocents: " + Eurocent;
                    break;
                case 3:
                    return "Hryvnias: " + Hryvnia + "\nKopiykas: " + Kopiyka;
                    break;
                default:
                    throw new Exception("Invalid Mode");
                    break;
            }
        }
    }
    class Product:Money
    {
        public string ProductName { get; set; }
        public Product(int _Mode, uint _CurrencyNote, uint _CurrencyCoin,string _ProductName) : base(_Mode, _CurrencyNote, _CurrencyNote)
        {
            ProductName = _ProductName;
        }
        public void PriceDecrease(uint Price)
        {
            switch (Mode)
            {
                case 1:
                    Dollar -= Price;
                    break;
                case 2:
                    Euro -= Price;
                    break;
                case 3:
                    Hryvnia -= Price;
                    break;
                default:
                    break;
            }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Product: " + ProductName);
        }
        public override string ToString()
        {
            return base.ToString() + "Product: " + ProductName;
        }
    }
}
