using Factorial.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;

namespace Factorial.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class HomeView : MvxViewController<FactorialViewModel>
    {
        public HomeView() : base("HomeView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<HomeView, FactorialViewModel>();
            set.Bind(NText).To(vm => vm.N);
            set.Bind(CalculateButton).To(vm => vm.CalculateCommand);
            set.Bind(ResultLabel).To(vm => vm.Result);
            set.Apply();
        }
    }
}
