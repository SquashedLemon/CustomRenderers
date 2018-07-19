using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomRenderers
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            mySlider.StoppedDragging += MySlider_StoppedDragging;
		}

        public void MySlider_StoppedDragging(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Stopped Dragging", "OK");
        }
	}
}