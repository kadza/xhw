using System;
using xhw.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(PlatformPathProvider))]
namespace xhw.Droid
{
	public class PlatformPathProvider : IPlatformInfoProvider
	{
		public string GetPlatformName()
		{
			return "Android";
		}
	}
}
