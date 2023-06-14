namespace Program_8
{
    public class Emi
    {
        /// <summary>Emis the calculator.</summary>
        /// <param name="principal">The principal.</param>
        /// <param name="rate">The rate.</param>
        /// <param name="time">The time.</param>
        public void EmiCalculator(float principal, float rate, float time)
        {
            rate = rate / (12 * 100);
            time = time * 12;
            float emi = (principal * rate * (float)Math.Pow(1 + rate, time)) / (float)(Math.Pow(1 + rate, time) - 1);
            Console.WriteLine(emi);
        }

    }
}
