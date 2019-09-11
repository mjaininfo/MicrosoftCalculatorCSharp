using UIKit;

namespace WindowsCalculator.iOS
{
	public class Application
	{
		// Program starts here.
		static void Main(string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main(args, null, typeof(App));
		}
	}
}