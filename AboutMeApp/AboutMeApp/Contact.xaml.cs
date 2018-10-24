using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMeApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Contact : ContentPage
	{
		public Contact ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty (nameEntry.Text))
            {
                DisplayAlert("Error","Please enter a name","OK");
                return;
            }

            if (string.IsNullOrEmpty(emailEntry.Text))
            {
                DisplayAlert("Error", "Please enter an E-mail", "OK");
                return;
            }

            if (string.IsNullOrEmpty(messageEditor .Text))
            {
                DisplayAlert("Error", "Please enter soemthing", "OK");
                return;
            }

            DisplayAlert("Notice", "Your message has been sent!", "OK");
            return;

        }
    }
}