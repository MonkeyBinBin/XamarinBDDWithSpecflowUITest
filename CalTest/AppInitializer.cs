using System;
using Xamarin.UITest;

namespace CalTest
{
	public class AppInitializer
	{
		public static IApp StartApp (Platform platform)
		{
			if (platform == Platform.Android) {

				return ConfigureApp
					.Android
					.EnableLocalScreenshots()
					.StartApp ();
			} else if (platform == Platform.iOS) {

				return ConfigureApp
					.iOS
					.EnableLocalScreenshots()
					.StartApp ();
			}

			throw new ArgumentException ("Unsupported platform");
		}
	}
}

