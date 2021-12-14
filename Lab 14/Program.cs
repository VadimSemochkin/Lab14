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
            Cat cat = new Cat("Васька");
        }
    }
    abstract class Animal
    {

        public abstract string Name { get; set; }
        public Animal(string Name)
        {
           this.Name=Name;
        }
        public abstract string Say();
        public virtual void ShowInfo()
        {
            Console.WriteLine("имя:{0}", Name);
            Say();
        }

    }
    class Cat : Animal
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
                name = value;
            }

        }
        public Cat(string name) : base(name)
        {
            Name = name;
        }


        public override string Say()
        {
            
            string say = "Мяу";
            Console.WriteLine("Говорит {0}", say);
        }
    }

}
