using System;
using Xamarin.Forms;
using XamarinFormsNativeDemo.Views;

namespace XamarinFormsNativeDemo
{
    public partial class XamarinFormsNativeDemoPage : ContentPage
    {
        public XamarinFormsNativeDemoPage()
        {
            InitializeComponent();
        }

        private async void OnBuildInClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BuildInPage());
        }

        private async void OnCustomRendererClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomRendererPage());
        }

        private async void OnEffectClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EffectPage());
        }

        private async void OnPlatformSpecificsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlatformSpecificsPage());
        }

        private async void OnNativeViewsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NativePage());
        }
    }
}
