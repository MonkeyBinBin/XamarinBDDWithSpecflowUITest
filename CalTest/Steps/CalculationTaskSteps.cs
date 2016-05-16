using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using NUnit.Framework;

namespace CalTest
{
	[Binding]
	public class CalculationTaskSteps
	{
		readonly IApp app;
		public CalculationTaskSteps(){
			app = FeatureContext.Current.Get<IApp> ("App");
		}

		[Given(@"輸入(.*)按下\+")]
		public void Given輸入按下(int p0)
		{
			app.WaitForElement (query => query.Button ("+"));
			var inputs = p0.ToString ().ToCharArray ();
			foreach (var item in inputs) {
				app.Tap(query=>query.Button(item.ToString ()));
			}
			app.Tap (query => query.Button ("+"));
		}

		[Given(@"輸入(.*)")]
		public void Given輸入(int p0)
		{
			app.WaitForElement (query => query.Button ("+"));
			var inputs = p0.ToString ().ToCharArray ();
			foreach (var item in inputs) {
				app.Tap(query=>query.Button(item.ToString ()));
			}
		}

		[When(@"按下=")]
		public void When按下()
		{
			app.WaitForElement (query => query.Button ("="));
			app.Tap (query => query.Button ("="));
		}

		[Then(@"畫面顯示計算結果應為(.*)")]
		public void Then畫面顯示計算結果應為(int p0)
		{
			app.WaitForElement (query => query.Marked (p0.ToString ()));

			var expected = 1;

			var actual = app.Query (c => c.Marked(p0.ToString ())).Length;

			Assert.AreEqual (expected,actual);
		}
	}
}