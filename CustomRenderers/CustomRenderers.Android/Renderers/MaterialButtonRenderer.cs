using System;
using System.ComponentModel;
using Android.Graphics;
using Android.Support.V4.View;
using CustomRenderers.Custom_Controls;
using CustomRenderers.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Animation = Android.Animation;
using System.Runtime.Remoting.Contexts;

[assembly: ExportRenderer(typeof(MaterialButton), typeof(MaterialButtonRenderer))]
namespace CustomRenderers.Droid.Renderers
{
    public class MaterialButtonRenderer : ButtonRenderer
    {
        public MaterialButtonRenderer(Android.Content.Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement == null)
                return;

            Control.StateListAnimator = new Animation.StateListAnimator();

            UpdateMaterialShadow();

        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == "Elevation")
            {
                UpdateMaterialShadow();
            }
        }

        private void UpdateMaterialShadow()
        {
            var materialButton = (MaterialButton)Element;
            ViewCompat.SetElevation(this, materialButton.Elevation);
            ViewCompat.SetElevation(Control, materialButton.Elevation);
            UpdateLayout();
        }
    }
}