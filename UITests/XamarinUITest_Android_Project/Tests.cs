using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace XamarinUITest_Android_Project
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the Android app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            app = ConfigureApp
                .Android
                // TODO: Update this path to point to your Android app and uncomment the
                // code if the app is not included in the solution.
                //.ApkFile ("../../../Android/bin/Debug/UITestsAndroid.apk")
                .ApkFile(@"C:\Users\glo\Source\Repos\AwesomeProject\android\app\build\outputs\apk\app-debug.apk")
                //.InstalledApp("com.awesomeproject")
                .EnableLocalScreenshots()
                .StartApp();
        }
        
        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void TestAlert()
        {
            AwesomeProjectModel model = new AwesomeProjectModel(this.app);
            model.ClickTestButton();

            AwesomePopup popup = new AwesomePopup(this.app);
            string titleText = popup.GetTitle();
            Assert.AreEqual("Test Title", titleText, "The title of the alert box did not have the expected value.");

            string messageText = popup.GetMessage();
            Assert.AreEqual("Test alert message", messageText, "The message in the alert box did not have the expected value.");

            popup.ClickOK();
        }

        //[Test]
        public void Repl()
        {
            app.Repl();
        }
    }
}

