namespace calculadorarealkss
{
    public class Divisao : IOperacao
    {
        public double Calcular(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return a / b;
        }
    }
}
