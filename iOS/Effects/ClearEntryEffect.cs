using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using XamarinFormsNativeDemo.PlatformSpecifics.iOS;

//[assembly: ExportEffect(typeof(XamarinFormsNativeDemo.iOS.Effects.ClearEntryEffect), "ClearEntryEffect")]
namespace XamarinFormsNativeDemo.iOS.Effects
{
    /*

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

    */

    /*

    //Platform specifics version of effect
    public class ClearEntryEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            ConfigureControl();
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            //Trigger at runtime update of the control when attached property changes
            if (args.PropertyName == PlatformSpecifics.iOS.ClearEntryPlatformSpecific.IsClearEnabledProperty.PropertyName)
                ConfigureControl();
        }

        private void ConfigureControl()
        {
            //Use property on xamarin forms element to validate what needs to be done with the native control
            if (((Entry)Element).OnThisPlatform().GetIsClearEnabled())
                ((UITextField)Control).ClearButtonMode = UITextFieldViewMode.WhileEditing;
            else
                ((UITextField)Control).ClearButtonMode = UITextFieldViewMode.Never;
        }
    }

    */
}