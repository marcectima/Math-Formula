namespace Exercise1.Domain.Abstract
{
    public interface IBasicFormulas
    {
        double AreaOfCircle(double radius);
        double CircumferenceOfCircle(double radius);

        double VolumeOfHemisphere(double radius);
    }
}