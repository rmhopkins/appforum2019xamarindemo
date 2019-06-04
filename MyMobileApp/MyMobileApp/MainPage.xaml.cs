using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using MyMobileApp.Models;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Data;
using Microsoft.AppCenter.Crashes;
using System.Collections.ObjectModel;

namespace MyMobileApp
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Person> people = new ObservableCollection<Person>();
        public MainPage()
        {
            InitializeComponent();
            PeopleList.ItemsSource = people;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EntryText.Text))
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

        private async void Contacts_Clicked(object sender, EventArgs e)
        {
            var result = await Data.ListAsync<Person>(DefaultPartitions.AppDocuments);
            foreach (var item in result.CurrentPage.Items)
            {
                people.Add(new Person
                {
                    Name = item.DeserializedValue.Name,
                    Email = item.DeserializedValue.Email
                }); 
            }
        }
    }
}
