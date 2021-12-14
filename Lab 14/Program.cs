using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    abstract class Animal
    {
        
        public abstract string Name { get; set; }
        public Animal(string Name)
        {
            Name="nikto";
        }
        public abstract string Say();
        public virtual void ShowInfo()
        {
            Console.WriteLine("имя:{0}", Name);
            Say();
        }
        
    }
    class Cat:Animal
    {
        public string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = "Кошка";
            }

        }

        public override string Say()
        {
            Console.WriteLine("Говорит Мяу");
        }
    }
    class Dog:Animal
    {
        public string name;
    }
}
