using System;
using xhw.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(PlatformPathProvider))]
namespace xhw.iOS
{
	public class PlatformPathProvider : IPlatformInfoProvider
	{
		public string GetPlatformName()
		{
			return "iOS";
		}
	}
}
