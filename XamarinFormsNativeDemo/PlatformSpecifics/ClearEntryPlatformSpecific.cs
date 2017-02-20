using System;
using System.Linq;
using Xamarin.Forms;
using XamarinFormsNativeDemo.Effects;

namespace XamarinFormsNativeDemo.PlatformSpecifics.iOS
{
    //Set USING inside Namespace to not conflict with iOS ending on given namespace
    using Xamarin.Forms.PlatformConfiguration;

    public static class ClearEntryPlatformSpecific
    {
        public static readonly BindableProperty IsClearEnabledProperty = BindableProperty.Create("IsClearEnabled", typeof(bool), typeof(ClearEntryPlatformSpecific), false, propertyChanged: OnIsClearEnabledChanged);

        public static bool GetIsClearEnabled(BindableObject element)
        {
            return (bool)element.GetValue(IsClearEnabledProperty);
        }

        public static void SetIsClearEnabled(BindableObject element, bool value)
        {
            element.SetValue(IsClearEnabledProperty, value);
        }

        public static bool GetIsClearEnabled(this IPlatformElementConfiguration<iOS, Entry> config)
        {
            return GetIsClearEnabled(config.Element);
        }

        //Method group to enable Fluent code setting ( example page code behind )
        public static IPlatformElementConfiguration<iOS, Entry> SetIsClearEnabled(this IPlatformElementConfiguration<iOS, Entry> config, bool value)
        {
            SetIsClearEnabled(config.Element, value);
            return config;
        }

        private static void OnIsClearEnabledChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if ((bool)newValue)
            {
                AttachEffect(bindable as Entry);
            }
            else
            {
                DetachEffect(bindable as Entry);
            }
        }

        static void AttachEffect(Entry element)
        {
            IElementController controller = element;
            if (controller == null || controller.EffectIsAttached(EffectIds.ClearEntryEffect))
            {
                return;
            }
            element.Effects.Add(Effect.Resolve(EffectIds.ClearEntryEffect));
        }

        static void DetachEffect(Entry element)
        {
            IElementController controller = element;
            if (controller == null || !controller.EffectIsAttached(EffectIds.ClearEntryEffect))
            {
                return;
            }

            var toRemove = element.Effects.FirstOrDefault(e => e.ResolveId == Effect.Resolve(EffectIds.ClearEntryEffect).ResolveId);
            if (toRemove != null)
            {
                element.Effects.Remove(toRemove);
            }
        }
   }
}
