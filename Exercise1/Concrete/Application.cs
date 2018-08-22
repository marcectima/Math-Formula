#region System namespaces
using System;
#endregion

#region Solution namespaces
using Exercise1.Abstract;
using Exercise1.Domain.Abstract;
#endregion


namespace Exercise1.Concrete
{
    class Application : IApplication
    {
        IBasicFormulas basic;
        IIntermediateFormulas intermediate;
        IAdvancedFormulas advanced;

        #region Constructor
        public Application(IBasicFormulas basic
                          , IIntermediateFormulas intermediate
                          , IAdvancedFormulas advanced)
        {
            this.basic = basic;
            this.intermediate = intermediate;
            this.advanced = advanced;
        }
        #endregion

        public void Run()
        {
            Console.WriteLine("Welcome to the user interface for Exercise 1.\n");
            Console.WriteLine("Please note, you must implement the methods for this exercise (look in the \"Task List\") in order for this interface to be useful.");
            Console.WriteLine("If you implement the methods in order, you'll be able to use this interface to test as you go.\n\n");

            Console.WriteLine("Basic formulas");
            Console.WriteLine("--------------");
            Console.WriteLine("Circumference and Area of a Circle:");

            string input = "";

            do
            {
                try
                {
                    input = "";

                    Console.Write("Enter the radius of your circle (or just press \"Enter\" to continue): ");
                    input = Console.ReadLine();

                    if (input != "")
                    {
                        var n = Double.Parse(input);

                        Console.WriteLine($"Circumference of a circle with radius {n}: {this.basic.CircumferenceOfCircle(n)}");
                        Console.WriteLine($"Area of a circle with radius {n}: {this.basic.AreaOfCircle(n)}\n");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Looks like you entered an invalid value. Let's try that again.\n");
                }
            } while (input != "");

            Console.WriteLine("\nVolume of a hemisphere:");

            do
            {
                input = "";

                Console.Write("Enter the radius of your hemisphere (or just press \"Enter\" to continue): ");
                input = Console.ReadLine();

                if (input != "")
                {
                    try
                    {
                        var n = Double.Parse(input);

                        Console.WriteLine($"Volume of a hemisphere with radius {n}: {this.basic.VolumeOfHemisphere(n)}\n");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Looks like you entered an invalid value. Let's try that again.\n");

                    }
                }
            } while (input != "");


            Console.WriteLine("\n\nIntermediate formulas");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Area of a triangle:");

            do
            {
                try
                {
                    input = "";

                    Console.Write("Enter the length of the first side of your triangle (or just press \"Enter\" to continue): ");
                    input = Console.ReadLine();

                    if (input != "")
                    {
                        var a = Double.Parse(input);

                        Console.Write("Now, enter the length of the second side of your triangle: ");
                        var b = Double.Parse(Console.ReadLine());

                        Console.Write("Now, the third side: ");
                        var c = Double.Parse(Console.ReadLine());

                        Console.WriteLine($"Area of a triangle with sides {a}, {b}, {c}: {this.intermediate.AreaOfTriangle(a, b, c)}\n");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Looks like you entered an invalid value. Let's try that again.\n");
                }
            } while (input != "");


            Console.WriteLine("\n\nAdvanced formulas");
            Console.WriteLine("-------------------");
            Console.WriteLine("Quadratic equation:");

            do
            {
                input = "";

                Console.Write("Enter the value for the 'a' parameter of the quadratic equation: (or just press \"Enter\" to continue): ");
                input = Console.ReadLine();

                if (input != "")
                {
                    try
                    {
                        var a = Double.Parse(input);

                        Console.Write("Now, enter the 'b' parameter: ");
                        var b = Double.Parse(Console.ReadLine());

                        Console.Write("Now, the 'c' parameter: ");
                        var c = Double.Parse(Console.ReadLine());

                        if (this.advanced.QuadraticEquation(a, b, c).Length == 0)
                        {
                            Console.WriteLine($"No results for quadratic equation with parameters a={a}, b={b}, c={c}.");
                        }
                        else
                        {
                            Console.WriteLine($"Results of the quadratic equation with parameters a={a}, b={b}, c={c}:");

                            foreach (var i in this.advanced.QuadraticEquation(a, b, c))
                            {
                                Console.WriteLine($"\t{i}");
                            }
                        }
                        Console.WriteLine();
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Looks like you entered an invalid value. Let's try that again.\n");
                    }
                }
            } while (input != "");
        }
    }
}