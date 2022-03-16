using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Lemon:Fruit
    {
        public Lemon(string vitamin) : base(vitamin)
        {
            Vitamin = vitamin;
        }
        public override string ToString()
        {
            return $"{Vitamin}";
        }
    }
    }

