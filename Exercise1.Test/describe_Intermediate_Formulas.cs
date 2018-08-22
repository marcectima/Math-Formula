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
    class describe_Intermediate_Formulas : nspec
    {
        IntermediateFormulas target;

        void before_each()
        {
            target = new IntermediateFormulas();
        }

        void area_of_triangle()
        {
            context["when triangle is 3/4/5"] = () =>
                it["result is 6"] = () =>
                    target.AreaOfTriangle(3, 4, 5)
                          .ShouldBe(6);

            context["when radius is 3/3/3"] = () =>
                it["result is sqrt(15.1875)"] = () =>
                    target.AreaOfTriangle(3, 3, 3)
                          .ShouldBe(Math.Sqrt(15.1875));
        }
    }
}
