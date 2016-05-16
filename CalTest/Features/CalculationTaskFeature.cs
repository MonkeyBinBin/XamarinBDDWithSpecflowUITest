using System;
using NUnit.Framework;
using Xamarin.UITest;
using TechTalk.SpecFlow;

namespace CalTest
{
	[TestFixture (Platform.Android)]
	[TestFixture (Platform.iOS)]
	public partial class 加法計算Feature
	{
		IApp app;
		Platform platform;

		public 加法計算Feature(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp (platform);		
			FeatureContext.Current.Add ("App", app);
		}
	}
}
