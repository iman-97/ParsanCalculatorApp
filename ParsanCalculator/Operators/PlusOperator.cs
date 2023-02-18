namespace ParsanCalculator.Operators;

public class PlusOperator : Operator
{
    public PlusOperator(double left, double right) : base(left, right)
    {
    }

    public override double Compute() => left + right;

}
