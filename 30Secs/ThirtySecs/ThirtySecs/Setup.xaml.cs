using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThirtySecs
{
	public partial class Setup : ContentPage
	{
        GameDifficulty difficulty = GameDifficulty.Normal;

		public Setup ()
		{
			InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            numberWords.Text = Math.Floor(e.NewValue).ToString();
        }

        private void EasyButton_Clicked(object sender, EventArgs e)
        {
            easyButton.BackgroundColor = Color.DarkGray;
            normalButton.BackgroundColor = Color.FromHex("#3c80d1");
            hardButton.BackgroundColor = Color.FromHex("#3c80d1");

            difficulty = GameDifficulty.Easy;
        }

        private void NormalButton_Clicked(object sender, EventArgs e)
        {
            easyButton.BackgroundColor = Color.FromHex("#3c80d1");
            normalButton.BackgroundColor = Color.DarkGray;
            hardButton.BackgroundColor = Color.FromHex("#3c80d1");

            difficulty = GameDifficulty.Normal;
        }

        private void HardButton_Clicked(object sender, EventArgs e)
        {
            easyButton.BackgroundColor = Color.FromHex("#3c80d1");
            normalButton.BackgroundColor = Color.FromHex("#3c80d1");
            hardButton.BackgroundColor = Color.DarkGray;

            difficulty = GameDifficulty.Hard;
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}