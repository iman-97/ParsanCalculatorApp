namespace ParsanCalculator.Operators;

public class DevideOperator : Operator
{
    public DevideOperator(double left, double right) : base(left, right)
    {
    }

    public override double Compute() => left / right;

}
