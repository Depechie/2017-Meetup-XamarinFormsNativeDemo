using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;

[assembly: ExportEffect(typeof(XamarinFormsNativeDemo.iOS.Effects.ClearEntryEffect), "ClearEntryEffect")]
namespace XamarinFormsNativeDemo.iOS.Effects
{
    public class ClearEntryEffect : PlatformEffect
    {
        private UITextFieldViewMode _initialMode;

        protected override void OnAttached()
        {
            ConfigureControl();
        }

        protected override void OnDetached()
        {
            ResetControl();
        }

        private void ConfigureControl()
        {
            _initialMode = ((UITextField)Control).ClearButtonMode;
            ((UITextField)Control).ClearButtonMode = UITextFieldViewMode.WhileEditing;
        }

        private void ResetControl()
        {
            ((UITextField)Control).ClearButtonMode = _initialMode;
        }
    }
}