using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class HealthParameter<T>
    {
        public string Name { get; set; }
        public T Current { get; set; }
        public T Standard { get; set; }
        public double Alpha { get; set; }

        public override string ToString()
        {
            return $"ParameterName: {Name} StandardValue: {Standard} CurrentValue: {Current}";
        }

        public virtual float SterssFactor()
        {
            double result = Convert.ToDouble(Current) / Convert.ToDouble(Standard);
            return (float)Math.Round(result * Alpha, 2); 
        }

        internal int StressFactor()
        {
            throw new NotImplementedException();
        }
    }

}
