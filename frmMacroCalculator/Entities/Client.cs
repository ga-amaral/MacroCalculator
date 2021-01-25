using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMacroCalculator.Entities
{
    class Client
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public bool Goal { get; set; }
        public double Factor { get; set; }
        public double protein;
        public double fat;
        public double carbs;
        public double Total;
        public Goals goals { get; set; } = new Goals();

        public Client()
        {
        }
        public Client(int height, double weight, int age, bool gender, bool goal, double factor)
        {
            Height = height;
            Weight = weight;
            Age = age;
            Gender = gender;
            Goal = goal;
            Factor = factor;
        }

        public double TBM()
        {
            double Result;

            if (Gender)
            {
                Result = (10 * Weight) + (6.25 * Height) - (5 * Age) + 5;
            }
            else
            {
                Result = (10 * Weight) + (6.25 * Height) - (5 * Age) - 161;
            }

            return Result;
        }
        public void Values()
        {
            if (Goal)
            {
                protein = (Weight * 2.3) * 4;
                fat = (Weight * 0.6) * 9;
                carbs = (TBM() * goals.MainGoal(Goal) * Factor - protein - fat) ;
                Total = TBM() * Factor * goals.MainGoal(Goal);
            }
            else
            {
                protein = (Weight * 2.3) * 4;
                fat = (Weight * 0.6) * 9;
                carbs = ((TBM() * Factor) + goals.MainGoal(Goal) - protein - fat);
                Total = TBM() * Factor + goals.MainGoal(Goal);
            }
        }

        public virtual string ToString()
        {
            return "Proteína: " + protein.ToString("F2") + " kcal"
                + "\n\nGorgura: " + fat.ToString("F2") + " kcal"
                + "\n\nCarboidrato: " + carbs.ToString("F2") + " kcal"
                + "\n\nTotal de Calorias Diárias: " + Total.ToString("F2") + " kcal";
        }
    }
}
