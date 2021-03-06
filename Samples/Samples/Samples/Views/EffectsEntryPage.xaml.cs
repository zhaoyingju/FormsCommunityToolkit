﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsCommunityToolkit.Samples.Views
{
    public partial class EffectsEntryPage : ContentPage
    {
        public EffectsEntryPage()
        {
            InitializeComponent();
        }

        private async void OnCapitalizeKeyboardButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EffectsEntryCapitalizeKeyboardPage());
        }

        private async void OnClearButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EffectsEntryClearPage());
        }
    }
}