namespace ParsanCalculator.Operators;

public class MinusOperator : Operator
{
    public MinusOperator(double left, double right) : base(left, right)
    {
    }

    public override double Compute() => left - right;

}
