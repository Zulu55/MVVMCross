using Android.App;
using Android.OS;
using Factorial.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace Factorial.Android.Views
{
	[Activity(Label = "@string/app_name")]
	public class FactorialView : MvxActivity<FactorialViewModel>
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.FactorialPage);
		}
	}
}