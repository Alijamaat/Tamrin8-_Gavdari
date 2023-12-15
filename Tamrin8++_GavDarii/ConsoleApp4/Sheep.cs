using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public  class Sheep : Animal
    {
        public static int SheepsNumber;

        public Sheep(int MaxLife,
                   bool Gender,
                   double Weight,
                   List<Environment> Environments,
                   List<Product> Products,
                   List<Cost> Costs)
        {
            SheepsNumber++;
            this.ID = SheepsNumber;
            this.MaxLife = MaxLife;
            this.Gender = Gender;
            this.Weight = Weight;
            this.Environments = Environments;
            this.Products = Products;
            this.Costs = Costs;
            BirthDate = DateTime.Today;

            Name = $"S{(this.Gender ? 'M' : 'F')}{BirthDate.Year}{BirthDate.Month}{BirthDate.Day}{ID}";
        }

        public Sheep()
        {
        }

        public int ID { get; init; }

        public string Name { get; init; }

        public DateTime BirthDate { get; init; }

        public int MaxLife { get; init; }

        public List<Environment> Environments { get; set; }

        public List<Product> Products { get; set; }

        public List<Cost> Costs { get; set; }

        public double Weight { get; set; }

        public bool Gender { get; set; }

        public override double AverageStressFactor(Environment Environment)
        {
            double TotalStressFactor = 0;

            TotalStressFactor += Environment.TDS.StressFactor()
                  + Environment.Temperature.StressFactor()
                  + Environment.Density.StressFactor()
                  + Environment.Decibel.StressFactor()
                  + Environment.AQI.StressFactor()
                  + Environment.Oxygen.StressFactor();

            return Math.Round(TotalStressFactor / (double)6, 2);
        }

        public override int Life()
        {
            double Life = 0;
            foreach (Environment Environment in Environments)
            {
                Life += AverageStressFactor(Environment);
            }

            return (int)Math.Floor(Life);
        }

        public override int TimeToDie()
        {
            double RemainLife = (MaxLife * 365) - Life();
            return (int)Math.Ceiling(RemainLife / 365);
        }

        public override double KillPriority()
        {
            int Difference = (MaxLife * 365) - Life();
            double KillPriority = 0;
            switch (Difference)
            {
                case int difference when difference <= 730:
                    KillPriority = 1;
                    break;
                case int difference when difference > 730 && difference <= 1825:
                    KillPriority = 0.75;
                    break;
                case int difference when difference > 1825 && difference <= 3285:
                    KillPriority = 0.5;
                    break;
                case int difference when difference > 3285 && difference <= 4745:
                    KillPriority = 0.25;
                    break;
                default:
                    KillPriority = 0;
                    break;
            }

            return KillPriority;
        }

        public override decimal CostPerDay()
        {
            decimal TotalCost = 0;
            foreach (Cost Cost in Costs)
            {
                TotalCost += (decimal)Cost.Price * (decimal)Cost.DailyUsage;
            }
            return TotalCost;
        }

        public override decimal IncomePerDay()
        {
            decimal TotalIncome = 0;
            foreach (Product Product in Products)
            {
                TotalIncome += (decimal)Product.Price + (decimal)Product.DailyProduce;
            }
            return TotalIncome;
        }

        public override string ToString() =>
            $"Name: {Name} BirthDate: {BirthDate} Age: {Math.Round((double)Life() / 365, 0)}";

        public override decimal MeatIncome(decimal MeatPrice) => (decimal)Weight * MeatPrice;




    }
}
