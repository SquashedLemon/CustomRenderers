using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomRenderers
{
    public class RoundedEntryView : Entry
    {
        public RoundedEntryView()
        {
            this.HeightRequest = 50;
        }

        public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(Image), typeof(string), typeof(RoundedEntryView), string.Empty);
        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(CornerRadius), typeof(double), typeof(RoundedEntryView), 0);
        public static readonly BindableProperty LineColorProperty = BindableProperty.Create(nameof(LineColor), typeof(Color), typeof(RoundedEntryView), Color.White);
        public static readonly BindableProperty ImageHeightProperty = BindableProperty.Create(nameof(ImageHeight), typeof(int), typeof(RoundedEntryView), 40);
        public static readonly BindableProperty ImageWidthProperty = BindableProperty.Create(nameof(ImageWidth), typeof(int), typeof(RoundedEntryView), 40);
        public static readonly BindableProperty ImageAlignmentProperty = BindableProperty.Create(nameof(ImageAlignment), typeof(ImageAlignment), typeof(RoundedEntryView), ImageAlignment.Left);

        public string Image
        {
            get => (string)base.GetValue(ImageProperty);
            set => base.SetValue(ImageProperty, value);
        }

        public double CornerRadius
        {
            get => (double)base.GetValue(CornerRadiusProperty);
            set => base.SetValue(CornerRadiusProperty, value);
        }

        public Color LineColor
        {
            get => (Color)base.GetValue(LineColorProperty);
            set => base.SetValue(LineColorProperty, value);
        }

        public int ImageHeight
        {
            get => (int)base.GetValue(ImageHeightProperty);
            set => base.SetValue(ImageHeightProperty, value);
        }

        public int ImageWidth
        {
            get => (int)base.GetValue(ImageWidthProperty);
            set => base.SetValue(ImageWidthProperty, value);
        }

        public ImageAlignment ImageAlignment
        {
            get => (ImageAlignment)base.GetValue(ImageAlignmentProperty);
            set => base.SetValue(ImageAlignmentProperty, value);
        }
    }

    public enum ImageAlignment
    {
        Left,
        Right
    }
}
