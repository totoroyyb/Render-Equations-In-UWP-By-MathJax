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
using RenderMathUWP.Helper;

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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = MathBox.Text;
            string langStr;
            
            if (LangComboBox.SelectedItem == TexItem)
            {
                langStr = "equationtex";

                //Since C# will automatically double the backslash in the string
                //so we don't need use the function below
                //if you want to make it double backslash
                //uncomment the function below
                //str = LatexStringFormer.AddBackSlash(str);
            }
            else
            {
                langStr = "equationml";
            }

            string combinedString = langStr + "," + str;

            try
            {
                await TestWebView.InvokeScriptAsync("ChangeEquation", new string[] { combinedString });
            }
            catch
            {

            }
        }

        private async void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await TestWebView.InvokeScriptAsync("LoadMathJax", null);
            }
            catch
            {

            }

            MathBox.IsEnabled = true;
            LangComboBox.IsEnabled = true;
            ChangeButton.IsEnabled = true;
        }
    }
}
