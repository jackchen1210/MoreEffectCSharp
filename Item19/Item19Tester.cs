using System.Collections.Generic;

namespace Item19
{
    public class Item19Tester
    {
        public void Main()
        {
            System.Console.WriteLine("1.------------");
            var obj1 = new Animal();
            obj1.Foo(new Apple());//In Animal.Foo

            System.Console.WriteLine("2.------------");
            var obj2 = new Tiger();
            obj2.Foo(new Apple());//In Tiger.Foo
            obj2.Foo(new Fruit());//In Tiger.Foo
            ((Animal)obj2).Foo(new Apple());//In Animal.Foo

            System.Console.WriteLine("3.------------");
            Animal obj3 = new Tiger();
            obj3.Foo(new Apple());//In Animal.Foo

            System.Console.WriteLine("4.------------");
            var obj4 = new Tiger();
            ((Animal)obj4).Foo(new Apple());//In Animal.Foo
            
            System.Console.WriteLine("5.------------");
            var obj5 = new Tiger();
            obj5.Bar(new Apple());//In Animal.Bar
            System.Console.WriteLine("6.------------");
            var sequence = new List<Fruit>{new Apple(),new Apple()};
            var obj6 = new Tiger();
            obj6.Baz(sequence);
        }
    }

    public class Fruit { }
    public class Apple : Fruit { }

    public class Animal
    {
        public void Foo(Apple apple)
        {
            System.Console.WriteLine("In Animal.Foo");
        }

        public void Bar(Fruit fruit)
        {
            System.Console.WriteLine("In Animal.Bar");
        }

        public void Baz(IEnumerable<Fruit> apples){
            System.Console.WriteLine("In Animal.Foo2");
        }
    }

    public class Tiger : Animal
    {
        public void Foo(Fruit apple)
        {
            System.Console.WriteLine("In Tiger.Foo");
        }
        public void Bar(Fruit fruit,Fruit fruit1=null)
        {
            System.Console.WriteLine("In Tiger.Bar");
        }
        public void Baz(IEnumerable<Apple> fruits){
            System.Console.WriteLine("In Tiger.Foo2");
        }
    }
}