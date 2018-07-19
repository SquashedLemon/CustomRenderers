using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomRenderers.Custom_Controls
{
    public class CustomSlider : View
    {
        public event EventHandler StoppedDragging;
        public event EventHandler<ValueChangedEventArgs> ValueChanged;
        public event EventHandler<ValueChangedEventArgs> MaximumChanged;
        public event EventHandler<ValueChangedEventArgs> MinimumChanged;

        public static readonly BindableProperty ValueChangedProperty =
            BindableProperty.Create(nameof(Value), typeof(int), typeof(CustomSlider), 40);
        public static readonly BindableProperty MaximumChangedProperty =
            BindableProperty.Create(nameof(Maximum), typeof(int), typeof(CustomSlider), 100);
        public static readonly BindableProperty MinimumChangedProperty =
            BindableProperty.Create(nameof(Minimum), typeof(int), typeof(CustomSlider), 0);

        public int Value
        {
            get => (int)base.GetValue(ValueChangedProperty);
            set
            {
                ValueChanged?.Invoke(this, new ValueChangedEventArgs((int)base.GetValue(ValueChangedProperty), value));
                base.SetValue(ValueChangedProperty, value);
            }
        }

        public int Maximum
        {
            get => (int)base.GetValue(MaximumChangedProperty);
            set
            {
                MaximumChanged?.Invoke(this, new ValueChangedEventArgs((int)base.GetValue(MaximumChangedProperty), value));
                base.SetValue(MaximumChangedProperty, value);
            }
        }

        public int Minimum
        {
            get => (int)base.GetValue(MinimumChangedProperty);
            set
            {
                MinimumChanged?.Invoke(this, new ValueChangedEventArgs((int)base.GetValue(MinimumChangedProperty), value));
            }
        }
        
        public void OnStoppedDragging()
        {
            StoppedDragging?.Invoke(this, EventArgs.Empty);
        }
    }
}
