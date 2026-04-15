using BuilderMmdoCoursework.src.Calculator;
using System;

namespace Mmdo.Services
{
    public class LinearConstraint
    {
        public double[] vars;
        public double b;

        public LinearConstraint(double[] vars, double b)
        {
            this.vars = vars;
            this.b = b;
        }
    }

    public class ObjectiveFunction
    {
        public double[] variables;

        public ObjectiveFunction(double[] variables)
        {
            this.variables = variables;
        }
    }

    public class PivotCoordinates
    {
        public Tuple<int, int> index;
        public TypeIteration result;

        public PivotCoordinates(Tuple<int, int> index, TypeIteration result)
        {
            this.index = index;
            this.result = result;
        }
    }

    public class SimplexStep
    {
        public SimplexSnapshot table;
        public TypeIteration resType;

        public SimplexStep(SimplexSnapshot tableScreenshot, TypeIteration result)
        {
            table = tableScreenshot;
            resType = result;
        }
    }
}
