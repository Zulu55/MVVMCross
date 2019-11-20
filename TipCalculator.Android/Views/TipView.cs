using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using TipCalculator.Core.ViewModels;

namespace TipCalculator.Android.Views
{
	[Activity(Label = "@string/app_name")]
	public class TipView : MvxActivity<TipViewModel>
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.TipPage);
		}
	}
}