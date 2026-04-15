using BuilderMmdoCoursework.src.Calculator;
using System;

namespace Mmdo.Services
{
    public class Constraint
    {
        public double[] vars;
        public double b;

        public Constraint(double[] vars, double b)
        {
            this.vars = vars;
            this.b = b;
        }
    }

    public class TargetFunction
    {
        public double[] variables;

        public TargetFunction(double[] variables)
        {
            this.variables = variables;
        }
    }

    public class VectorElement
    {
        public Tuple<int, int> index;
        public TypeIteration result;

        public VectorElement(Tuple<int, int> index, TypeIteration result)
        {
            this.index = index;
            this.result = result;
        }
    }

    public class IterationData
    {
        public SimplexSnapshot table;
        public TypeIteration resType;

        public IterationData(SimplexSnapshot tableScreenshot, TypeIteration result)
        {
            table = tableScreenshot;
            resType = result;
        }
    }
}
