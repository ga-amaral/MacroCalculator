namespace frmMacroCalculator.Entities
{
    class Function : Client
    {
        public Client client = new Client();


        public Function()
        {
        }
        public Function(string name, int height, double weight, int age, bool gender, bool goal, double factor)
            : base(name, height, weight, age, gender, goal, factor)
        {
        }
        public void Values02()
        {

            if (Goal)
            {
                protein = (Weight * 2.3);
                fat = (Weight * 0.6);
                carbs = (TBM() * Factor * goals.MainGoal(Goal) - protein*4 - fat*9)/4;
            }
            else
            {
                protein = (Weight * 2.3);
                fat = (Weight * 0.6);
                carbs = ((TBM() * Factor)+ goals.MainGoal(Goal) - protein*4 - fat*9)/4;
            }
            //protein = (Weight * 2.5);
            //fat = (Weight * 0.6);
            //carbs = (TBM() * Factor - protein * 4 - fat * 9) / 4;
            //Total = TBM() * Factor;
        }

        public override string ToString()
        {
            return "Proteína: " + protein.ToString("F2") + " g"
                + "\n\nGorgura: " + fat.ToString("F2") + " g"
                + "\n\nCarboidrato: " + carbs.ToString("F2") + " g";
        }
    }
}
