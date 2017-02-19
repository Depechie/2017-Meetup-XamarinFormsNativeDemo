using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsNativeDemo.iOS.Renderers;

[assembly: ExportRenderer(typeof(Entry), typeof(ClearEntryRenderer))]
namespace XamarinFormsNativeDemo.iOS.Renderers
{
    public class ClearEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
                //Control.ClearButtonMode = UIKit.UITextFieldViewMode.WhileEditing;
        }
    }
}
