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
            string catName = "Кисуля";
            string dogName = "Рэкс";
            Cat cat = new Cat(catName);
            Dog dog = new Dog(dogName);
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {

        public abstract string Name { get; set; }
        public Animal(string name)
        {
           Name=name;
        }
        public abstract void Say();
        public  void ShowInfo()
        {
            Console.Write(" Меня зовут {0}, ", Name);
            Say();
        }

    }
    class Cat : Animal
    {
        public string name;
        public Cat(string name)
            : base(name)
        {
            
        }
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
       


        public override void Say()
        {
            
            Console.WriteLine("Мяу");
        }
    }
    class Dog : Animal
    {
        public string name;
        public Dog(string name)
            : base(name)
        {

        }
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



        public override void Say()
        {

            Console.WriteLine("Гав");
        }
    }

}
