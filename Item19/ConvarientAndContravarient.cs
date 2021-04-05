using System.Collections.Generic;
using System;

namespace Item19
{
    public class ConvarientAndContravarient
    {
        public void Main(){
            // IEnumerable<Fruit> fruits = new List<Apple>();
            // IEnumerable<Apple> apples = new List<Fruit>(); //Compilier Error
            // void AppleFunc(Apple apple){}
            // void FruitFunc(Fruit fruit){}
            // Action<Fruit> fruitAc = AppleFunc; //Compilier Error
            // fruitAc = FruitFunc;
            // Action<Apple> appleAc = AppleFunc;
            // appleAc = FruitFunc;
        }
    }
}