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
using System.Collections.Generic;
#endregion


namespace Exercise1.Test
{
    class describe_Advanced_Formulas : nspec
    {
        AdvancedFormulas target;

        void before_each()
        {
            target = new AdvancedFormulas();
        }

        void quadratic_equation()
        {
            context["when parameters are 3, 4, 2"] = () =>
                it["result is no real results"] = () =>
                    target.QuadraticEquation(3, 4, 2)
                          .ShouldBeEmpty();

            context["when parameters are 9, 12, 4"] = () =>
                it["result is -(2/3)"] = () =>
                {
                    var res = target.QuadraticEquation(9, 12, 4);

                    res.ShouldBe(new double[] { -(2 / 3.0) });
                };

            context["when parameters are 1, -2, -4"] = () =>
                it["result is 1 ± 0.5 * Sqrt(20)"] = () =>
                {
                    var res = target.QuadraticEquation(1, -2, -4);
                    Array.Sort(res);

                    res.ShouldBe(new double[] { (1 - Math.Sqrt(20) / 2)
                                              , (1 + Math.Sqrt(20) / 2) });
                };
        }
    }
}
