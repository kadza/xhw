using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace xhw
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart()
		{
			AppCenter.Start(
				"android=d4c41a7c-af61-45cd-9c73-8fc226611794;ios=519295fd-2c98-4010-b637-734a8c464f27",
				typeof(Analytics),
				typeof(Crashes)
			);
			Analytics.TrackEvent("My event");
			Crashes.TrackError(new Exception("My error"));
			//Crashes.GenerateTestCrash();
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
