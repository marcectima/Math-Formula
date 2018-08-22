#region Third party namespaces
using SimpleInjector;
#endregion

#region Solution namespaces
using Exercise1.Abstract;
using Exercise1.Concrete;
using Exercise1.Domain.Abstract;
using Exercise1.Domain.Concrete;
#endregion


namespace Exercise1
{
    class Program
    {
        #region Dependency Injection
        static readonly Container container;

        static Program()
        {
            // From https://simpleinjector.readthedocs.io/en/latest/quickstart.html:
            // 1. Create a new Simple Injector container
            container = new Container();

            // 2. Configure the container (register)
            container.Register<IBasicFormulas,        BasicFormulas>();
            container.Register<IIntermediateFormulas, IntermediateFormulas>();
            container.Register<IAdvancedFormulas,     AdvancedFormulas>();

            container.Register<IApplication, Application>();

            // 3. Verify your configuration
            container.Verify();
        }
        #endregion

        static void Main(string[] args)
        {
            // Use dependency injection to build an IApplication
            var app = container.GetInstance<IApplication>();

            app.Run();
        }
    }
}
