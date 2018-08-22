#region System namespaces
using System;
#endregion

#region Third party namespaces
using NSpec;
using Shouldly;
using FsCheck;
#endregion

#region Solution namespaces
using Exercise1.Domain.Concrete;
#endregion


namespace Exercise1.Test
{
    class describe_Basic_Formulas : nspec
    {
        BasicFormulas target;

        void before_each()
        {
            target = new BasicFormulas();
        }

        void circle_area()
        {
            context["when radius is 1"] = () =>
                it["result is pi"] = () =>
                    target.AreaOfCircle(1)
                          .ShouldBe(Math.PI);

            context["when radius is 5"] = () =>
                it["result is 25*pi"] = () =>
                    target.AreaOfCircle(5)
                          .ShouldBe(25 * Math.PI);
        }

        void circle_circumference()
        {
            context["when radius is 1"] = () =>
                it["result is 2*pi"] = () =>
                    target.CircumferenceOfCircle(1)
                          .ShouldBe(2 * Math.PI);

            context["when radius is 5"] = () =>
                it["result is 10*pi"] = () =>
                    target.CircumferenceOfCircle(5)
                          .ShouldBe(10 * Math.PI);
        }

        void hemisphere_volume()
        {
            context["when radius is 1"] = () =>
                it["result is (2/3)*pi"] = () =>
                    target.VolumeOfHemisphere(1)
                          .ShouldBe((2.0/3) * Math.PI);

            context["when radius is 5"] = () =>
                it["result is (250/3)*pi"] = () =>
                    target.VolumeOfHemisphere(5)
                          .ShouldBe((250.0/3) * Math.PI);
        }
    }
}
