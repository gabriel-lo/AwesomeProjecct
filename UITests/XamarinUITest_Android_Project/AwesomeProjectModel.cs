using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.UITest;

using Xamarin.UITest.Queries;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace XamarinUITest_Android_Project
{
    public class AwesomeProjectModel
    {
        IApp app;

        public AwesomeProjectModel(IApp app)
        {
            this.app = app;
        }

        public void TapTestButton()
        {
            this.app.Tap(this.testButtonLocator);
        }

        public string GetTestButtonText()
        {
            this.app.WaitForElement(this.testButtonLocator);
            return this.app.Query(this.testButtonLocator)?.FirstOrDefault()?.Text;
        }

        private Query testButtonLocator = c => c.Id("NoResourceEntry-15");
    }
}
