using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Fruit
    {
        public string Vitamin;
        public Fruit(string vitamin)
        {
            Vitamin = vitamin;
        }
        public override string ToString()
        {
            return $"{Vitamin}";
        }
    }
}
