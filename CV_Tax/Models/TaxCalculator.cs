namespace CV_Tax.Models
{
    public class TaxCalculator
    {
        public decimal CalculateTax(decimal income)
        {
            return TaxBand(income);
        }

        private static decimal TaxBand(decimal income)
        {
            decimal tax = 0;
            var chargeableIncome = ChargeableIncome(income);
            if (chargeableIncome > 0)
            {
                decimal firstBand = Math.Min(chargeableIncome, 300000);
                tax += firstBand * 0.07m;
                chargeableIncome -= firstBand;
            }
            if (chargeableIncome > 0)
            {
                decimal secondBand = Math.Min(chargeableIncome, 300000);
                tax += secondBand * 0.11m;
                chargeableIncome -= secondBand;
            }
            if (chargeableIncome > 0)
            {
                decimal thirdBand = Math.Min(chargeableIncome, 500000);
                tax += thirdBand * 0.15m;
                chargeableIncome -= thirdBand;
            }
            if (chargeableIncome > 0)
            {
                decimal fourthBand = Math.Min(chargeableIncome, 500000);
                tax += fourthBand * 0.19m;
                chargeableIncome -= fourthBand;
            }
            if (chargeableIncome > 0)
            {
                decimal fifthBand = Math.Min(chargeableIncome, 1600000);
                tax += fifthBand * 0.21m;
                chargeableIncome -= fifthBand;
            }
            if (chargeableIncome > 0)
            {
                tax += chargeableIncome * 0.24m;
            }

            return tax;
        }

        private static decimal ChargeableIncome(decimal income)
        {
            return income - CRA(income);
        }

        private static decimal CRA(decimal income)
        {
            decimal cra = Math.Max(200000, (income * 0.01m)) + (income * 0.2m);
            return cra;
        }
    }
}
