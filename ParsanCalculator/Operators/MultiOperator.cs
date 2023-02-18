namespace ParsanCalculator.Operators;

public class MultiOperator : Operator
{
    public MultiOperator(double left, double right) : base(left, right)
    {
    }

    public override double Compute() => left * right;

}
