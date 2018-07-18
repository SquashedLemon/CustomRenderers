using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomRenderers;
using CustomRenderers.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RoundedBoxView), typeof(RoundedBoxViewRenderer))]
namespace CustomRenderers.Droid
{
    public class RoundedBoxViewRenderer : BoxRenderer
    {
#pragma warning disable CS0618 // Type or member is obsolete
        public RoundedBoxViewRenderer()
        {
            this.SetWillNotDraw(false);
        }
#pragma warning restore CS0618 // Type or member is obsolete

        public override void Draw(Canvas canvas)
        {
            RoundedBoxView rbv = (RoundedBoxView)this.Element;

            Paint paint = new Paint()
            {
                Color = rbv.Stroke.ToAndroid(),
                StrokeWidth = (float)rbv.StrokeThickness
            };

            paint.SetStyle(Paint.Style.Stroke);

            canvas.DrawPaint(paint);
        }
    }
}