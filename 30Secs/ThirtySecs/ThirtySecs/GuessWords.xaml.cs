using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThirtySecs
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GuessWords : ContentPage
	{
		public GuessWords ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}