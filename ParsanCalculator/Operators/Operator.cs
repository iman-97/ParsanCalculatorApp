using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsanCalculator.Operators;

public abstract class Operator
{
    protected double left;
    protected double right;

    public Operator(double left, double right)
    {
        this.left = left;
        this.right = right;
    }

    public abstract double Compute();

}
