using RenderMathUWP.View;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RenderMathUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            NaviView.SelectedItem = HomeNaviItem;
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationViewItem item = args.SelectedItem as NavigationViewItem;

            switch (item.Tag.ToString())
            {
                case "Home":
                    NaviFrame.Navigate(typeof(HomePage));
                    NaviView.Header = "Home";
                    break;

                case "Dyn":
                    NaviFrame.Navigate(typeof(Dynamic));
                    NaviView.Header = "Render Dynamically";
                    break;

                case "Stat":
                    NaviFrame.Navigate(typeof(Static));
                    NaviView.Header = "Render Statically";
                    break;
            }
        }
    }
}
