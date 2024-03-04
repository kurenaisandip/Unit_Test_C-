namespace InsuranceCalculator
{
    public class InsurancePremiumCalculator
    {

        public decimal CalulatePremuim(int age, bool isSmoker)
        {
            decimal premium = 100;

            if (age >= 18 && age <= 30)
            {
                premium += 50;
            }
            else if (age >= 31 && age <= 50)
            {
                premium += 100;
            }
            else if (age >= 50)
            {
                premium += 200;
            }

            if (isSmoker)
            {
                premium += 150;
            }

            return premium;
        }
        
        

    }
}