using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FirstApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat;

namespace FirstApp
{
    public class VMMainPage : AppViewModel
    {
        #region Binding Property

        private string _instructorValue;
        public string Instructor
        {
            get { return this._instructorValue; }
            private set { SetProperty(ref _instructorValue, value); }
        }
        #endregion

        #region Commands
        public ICommand CourseContentCommand { get; }
        #endregion

        public VMMainPage()
        {
            Instructor = "Carlos Orjuela";
            this.CourseContentCommand = new Command(CourseContentCommandExecute);
        }

        #region Methods

        private void CourseContentCommandExecute(object obj)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new HomePage());
        }

        #endregion

    }
}

