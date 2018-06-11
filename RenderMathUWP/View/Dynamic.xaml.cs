using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace RenderMathUWP.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Dynamic : Page
    {
        public Dynamic()
        {
            this.InitializeComponent();
        }

        private async void TestWebView_LoadCompleted(object sender, NavigationEventArgs e)
        {
            try
            {
                await TestWebView.InvokeScriptAsync("LoadMathJax", null);
            }
            catch
            {

            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await TestWebView.InvokeScriptAsync("ChangeEquation", new string[] { MathMLBox.Text });
            }
            catch
            {

            }
        }
    }
}
