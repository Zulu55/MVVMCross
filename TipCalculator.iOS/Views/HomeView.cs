using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using TipCalculator.Core.ViewModels;

namespace TipCalculator.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class HomeView : MvxViewController<TipViewModel>
    {
        public HomeView() : base("HomeView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<HomeView, TipViewModel>();
            set.Bind(AmountText).To(vm => vm.SubTotal);
            set.Bind(GenerositySlider).To(vm => vm.Generosity);
            set.Bind(TipLabel).To(vm => vm.Tip);
            set.Apply();
        }
    }
}
