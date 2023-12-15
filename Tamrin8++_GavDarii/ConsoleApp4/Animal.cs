using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class Animal
    {

        public int ID { get; init; }

        public string Name { get; init; }

        public DateTime BirthDate { get; init; }

        public static readonly int MaxLife = 9125 ;

        public List<Environment> Environments { get; set; }

        public List<Product> Products { get; set; }

        public List<Cost> Costs { get; set; }

        public double Weight { get; set; }

        public bool Gender { get; set; }

        public abstract double AverageStressFactor(Environment Environment);

        public abstract int Life();

        public abstract int TimeToDie();

        public abstract double KillPriority();

        public abstract decimal CostPerDay();

        public abstract decimal IncomePerDay();

        public abstract decimal MeatIncome(decimal MeatPrice);

        //public DateTime BirthDate { get; init; }
        //public static readonly int MaxLife = 30;
        //public List<Environment> Environments { get; init; }
        //public float Weight { get; set; }
        //public bool Gender { get; set; }
        //public string Name { get; set; }

        //public virtual float AverageStressFactor() => 0f;
        //public int Life() => DateTime.Now.Year - BirthDate.Year;
        //public int TimeToDie() => MaxLife - Life();
        //public virtual float KillPriority() => 0f;
        //public virtual int CostPerDay() => 0;
        //public virtual int ValuePerDay() => 0;


    }
}
