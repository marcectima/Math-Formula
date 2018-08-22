#region System namespaces
using System;
#endregion

#region Solution namespaces
using Exercise1.Domain.Abstract;
#endregion


namespace Exercise1.Domain.Concrete
{
    public class BasicFormulas : IBasicFormulas
    {
        public double CircumferenceOfCircle(double radius)
        {
            // TODO - 1 - Calculate the circumference of a circle
            double CircumferenceOfCircle = 2 * Math.PI;
            return CircumferenceOfCircle;
            throw new NotImplementedException();
        }

        public double AreaOfCircle(double radius)
        {
            // TODO - 2 - Calculate the area of a circle
            double AreaOfCircle = Math.PI * Math.Pow(radius,2); 
            return AreaOfCircle;
            throw new NotImplementedException();
        }

        public double VolumeOfHemisphere(double radius)
        {
            // TODO - 3 - Calculate the volume of a hemisphere
            double VolumeOfHemisphere = (4 / 3 * Math.PI * Math.Pow(radius, 3)) / 2;
            return VolumeOfHemisphere; 
            throw new NotImplementedException();
            
        }
    }
}
 