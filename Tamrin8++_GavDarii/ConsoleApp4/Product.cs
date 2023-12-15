using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public struct Product 
    {
        public string Name { get; set; }

        public string UnitOfMeasure { get; set; }

        public decimal Price { get; set; }

        public double DailyProduce { get; set; }

        public override string ToString() =>
            $"Name of product:{Name}, DailyProduce: {DailyProduce}{UnitOfMeasure}, Price: {Price}";

    }
}
