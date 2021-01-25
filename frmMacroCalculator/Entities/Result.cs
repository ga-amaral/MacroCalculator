using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMacroCalculator.Entities
{
    class Result
    {
        public double Protein { get; set; }
        public double Carbs { get; set; }
        public double Fat { get; set; }

        public Result()
        {
        }
        public Result(double protein, double carbs, double fat)
        {
            Protein = protein;
            Carbs = carbs;
            Fat = fat;
        }

        public override string ToString()
        {
            return Fat.ToString();
        }
    }
}
