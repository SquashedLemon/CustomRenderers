using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace CustomRenderers
{
    public class RoundedBoxView : BoxView
    {
        #pragma warning disable CS0618 // Type or member is obsolete
        public static readonly BindableProperty StrokeProperty = BindableProperty.Create<RoundedBoxView, Color>(x => x.Stroke, Color.Transparent);
        public static readonly BindableProperty StrokeThicknessProperty = BindableProperty.Create<RoundedBoxView, double>(x => x.StrokeThickness, default(double));
        public static readonly BindableProperty HasShadowProperty = BindableProperty.Create<RoundedBoxView, bool>(x => x.HasShadow, default(bool));
        #pragma warning restore CS0618 // Type or member is obsolete

        public Color Stroke
        {
            get => (Color)base.GetValue(StrokeProperty);
            set => base.SetValue(StrokeProperty, value);
        }

        public double StrokeThickness
        {
            get => (double)base.GetValue(StrokeThicknessProperty);
            set => base.SetValue(StrokeThicknessProperty, value);
        }

        public bool HasShadow
        {
            get => (bool)base.GetValue(HasShadowProperty);
            set => base.SetValue(HasShadowProperty, value);
        }
    }
}