using Factorial.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace Factorial.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<FactorialViewModel>();
        }
    }
}
