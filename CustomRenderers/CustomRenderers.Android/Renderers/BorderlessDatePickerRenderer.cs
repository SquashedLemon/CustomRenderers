using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using DatePicker = Xamarin.Forms.DatePicker;
using CustomRenderers.Custom_Controls;
using CustomRenderers.Droid.Renderers;

[assembly: ExportRenderer(typeof(BorderlessDatePicker), typeof(BorderlessDatePickerRenderer))]
namespace CustomRenderers.Droid.Renderers
{
    public class BorderlessDatePickerRenderer : DatePickerRenderer
    {
        public BorderlessDatePickerRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.Background = null;

                var layoutParams = new MarginLayoutParams(Control.LayoutParameters);

                layoutParams.SetMargins(0, 0, 0, 0);

                LayoutParameters = layoutParams;

                Control.LayoutParameters = layoutParams;
                Control.SetPadding(0, 0, 0, 0);

                SetPadding(0, 0, 0, 0);
            }
        }
    }
}