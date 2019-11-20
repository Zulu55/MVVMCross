using Foundation;
using MvvmCross.Platforms.Ios.Core;
using TipCalculator.Core;

namespace TipCalculator.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
    }
}


