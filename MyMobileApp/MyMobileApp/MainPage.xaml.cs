using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace MyMobileApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(EntryText.Text))
            {
                MyLabel.Text = $"You entered: {EntryText.Text}";
                await TextToSpeech.SpeakAsync(EntryText.Text);
            }
        }

        private async void Share_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EntryText.Text))
            {
                await Share.RequestAsync(new ShareTextRequest
                {
                    Text = EntryText.Text,
                    Title = "Share Text"
                });
            }
        }
    }
}
