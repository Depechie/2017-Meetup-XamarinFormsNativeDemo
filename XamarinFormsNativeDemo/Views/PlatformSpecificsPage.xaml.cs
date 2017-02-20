using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using XamarinFormsNativeDemo.PlatformSpecifics.iOS;

namespace XamarinFormsNativeDemo.Views
{
    public partial class PlatformSpecificsPage : ContentPage
    {
        public PlatformSpecificsPage()
        {
            InitializeComponent();

            //Fluent code configuration
            CharEntry.On<iOS>().SetIsClearEnabled(true);
        }
    }
}
