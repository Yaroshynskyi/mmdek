using BuilderMmdoCoursework.src.Calculator;
using System;

namespace Mmdo.Services
{
    public class LinearConstraint
    {
        public double[] Coefficients;
        public double Limit;

        public LinearConstraint(double[] coefficients, double limit)
        {
            Coefficients = coefficients;
            Limit = limit;
        }
    }

    public class ObjectiveFunction
    {
        public double[] Variables;

        public ObjectiveFunction(double[] variables)
        {
            Variables = variables;
        }
    }

    public class PivotCoordinates
    {
        public Tuple<int, int> Position;
        public StepResult Status;

        public PivotCoordinates(Tuple<int, int> position, StepResult status)
        {
            Position = position;
            Status = status;
        }
    }

    public class SimplexStep
    {
        public SimplexSnapshot Snapshot;
        public StepResult ResultType;

        public SimplexStep(SimplexSnapshot snapshot, StepResult resultType)
        {
            Snapshot = snapshot;
            ResultType = resultType;
        }
    }
}