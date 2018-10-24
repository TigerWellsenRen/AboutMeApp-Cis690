using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AboutMeApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void NavigationButton1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ABoutMEPage() );
        }

        private void NavigationButton2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Skill ());
        }

        private void NavigationButton3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Contact ());
        }

        private void NavigationButton4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyBio());
        }
       
    }
}
