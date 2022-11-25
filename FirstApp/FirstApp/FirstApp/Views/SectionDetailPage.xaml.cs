using System;
using System.Collections.Generic;
using FirstApp.ViewModels;
using Xamarin.Forms;

namespace FirstApp.Views
{
    public partial class SectionDetailPage : ContentPage
    {
        public SectionDetailPage(VMSection section)
        {
            InitializeComponent();

            var bindingViewModel = this.BindingContext as VMSectionDetailPage;
            bindingViewModel.Title = section.Title;
            bindingViewModel.VideoUrl = section.VideoUrl;
            bindingViewModel.Transcript = section.Transcript;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var bindingViewModel = this.BindingContext as VMSectionDetailPage;
            bindingViewModel.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            var bindingViewModel = this.BindingContext as VMSectionDetailPage;
            bindingViewModel.OnDisappearing();
        }

    }
}

