using Factorial.Core;
using Foundation;
using MvvmCross.Platforms.Ios.Core;

namespace Factorial.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
    }
}


