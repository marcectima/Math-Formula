#region System namespaces
using System;
#endregion

#region Solution namespaces
using Exercise1.Domain.Abstract;
#endregion


namespace Exercise1.Domain.Concrete
{
    public class IntermediateFormulas : IIntermediateFormulas
    {
        public double AreaOfTriangle(double a, double b, double c)
        {
            // TODO - 4 - Calculate the area of a triangle using Heron's formula

            double AreaOfTriangle = Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - c));
            return AreaOfTriangle;
            throw new NotImplementedException();
        }
    }
}
