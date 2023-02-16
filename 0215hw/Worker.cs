using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215hw
{
    abstract class Worker
    {
        public string Name { get; set; }
        public string Salary { get; set; }
        public string Experience { get; set; }
        public Worker(string _Name, string _Salary, string _Experience)
        {
            Name = _Name;
            Salary = _Salary;
            Experience = _Experience;
        }
        public virtual void Print()
        {
            Console.WriteLine("Name: " + Name + "\nSalary: " + Salary + "\nExperience: " + Experience);
        }

    }
    class President : Worker
    {
        public string Subordinates { get; set; }
        public President(string _Name, string _Salary, string _Experience, string _Subordinates):base(_Name, _Salary, _Experience)
        {
            Subordinates = _Subordinates;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Subordinates: "+ Subordinates);
        }
    }
    class Manager : Worker
    {
        public string Reports { get; set; }
        public Manager(string _Name, string _Salary, string _Experience, string _Reports) : base(_Name, _Salary, _Experience)
        {
            Reports = _Reports;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Reports: " + Reports);
        }
    }
    class Security : Worker
    {
        public string Cameras { get; set; }
        public Security(string _Name, string _Salary, string _Experience, string _Cameras) : base(_Name, _Salary, _Experience)
        {
            Cameras = _Cameras;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Cameras: " + Cameras);
        }
    }
    class Engineer : Worker
    {
        public string Projects { get; set; }
        public Engineer(string _Name, string _Salary, string _Experience, string _Projects) : base(_Name, _Salary, _Experience)
        {
            Projects = _Projects;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Projects: " + Projects);
        }
    }
}
