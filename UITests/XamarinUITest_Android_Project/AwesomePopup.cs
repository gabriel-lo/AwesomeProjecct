using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace XamarinUITest_Android_Project
{
    public class AwesomePopup
    {
        IApp app;

        public AwesomePopup(IApp app)
        {
            this.app = app;
        }

        public string GetTitle()
        {
            return this.app.Query(this.titleLocator)?.FirstOrDefault()?.Text;
        }

        public string GetMessage()
        {
            return this.app.Query(this.messageLocator)?.FirstOrDefault()?.Text;
        }

        public void ClickOK()
        {
            this.app.Tap(this.okLocator);
        }

        private Query titleLocator = c => c.Id("alertTitle");
        private Query messageLocator = c => c.Id("message");
        private Query okLocator = c => c.Text("OK");
    }
}
