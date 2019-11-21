﻿
using Android.App;
using Android.Content.PM;
using Factorial.Core;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;

namespace Factorial.Android.Views
{
	[Activity(
		Label = "@string/app_name",
		MainLauncher = true,
		Icon = "@drawable/icon",
		Theme = "@style/Theme.Splash",
		NoHistory = true,
		ScreenOrientation = ScreenOrientation.Portrait)]
	public class SplashView : MvxSplashScreenActivity<MvxAndroidSetup<App>, App>
	{
		public SplashView() : base(Resource.Layout.SplashPage)
		{
		}
	}
}