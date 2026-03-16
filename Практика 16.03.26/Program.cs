using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat(1);
            cat1.Method1(); cat1.Method2(); cat1.Method3();

            //Animal cat2 = new Animal(1); так нельзя
            Animal cat2 = new Cat(2);
            cat2.Method1(); cat2.Method2(); cat2.Method3();

        }

    }
    public abstract class Animal
    {
        private int _number;
        public Animal(int   number)
        {
            _number = number;
        }
        public void Method1()
        {
            Console.WriteLine("Animal method 1");
        }
        public virtual void Method2()//позволяет говорить животному
        {
            Console.WriteLine("Animal method 2");
        }
        public abstract void Method3();
    }
    public class Cat : Animal
    {
        public Cat(int number) : base(number) { }

        public new void Method1()//скрыли обычный метод
        {
            Console.WriteLine("Cat method 1");
        }
        public override void Method2()//переопределили виртуальный метод
        {
            Console.WriteLine("Cat method 2");
        }
        public override void Method3()//переопределили абстрактный метод
        {
            Console.WriteLine("Cat method 3");
        }
        
        
    }


}
