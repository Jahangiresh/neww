using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fruit> basket = new List<Fruit>();
            Apple apple = new Apple("B");
            Lemon lemon = new Lemon("C");
            Pinapple pinapple = new Pinapple("D");
            basket.Add(lemon);
            basket.Add(apple);
            basket.Add(pinapple);
            foreach (var item in basket)
            {
                Console.WriteLine(item);
            }
        }
    }
}
