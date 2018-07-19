using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomRenderers.Custom_Controls
{
    public class MaterialButton : Button
    {
        public static BindableProperty ElevationProperty = BindableProperty.Create(nameof(Elevation), typeof(float), typeof(MaterialButton), 4.0f);

        public float Elevation
        {
            get => (float)base.GetValue(ElevationProperty);
            set => base.SetValue(ElevationProperty, value);
        }
    }
}
