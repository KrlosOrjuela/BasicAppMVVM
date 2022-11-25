using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace FirstApp.ViewModels
{
    public class VMLoginPage : AppViewModel
    {
        #region Binding Property

        private string _userNameValue;
        public string UserName
        {
            get { return this._userNameValue; }
            private set { SetProperty(ref _userNameValue, value); }
        }

        private string _passwordValue;
        public string Password
        {
            get { return this._passwordValue; }
            private set { SetProperty(ref _passwordValue, value); }
        }
        #endregion

        #region Commands
        public ICommand LoginCommand { get; }
        #endregion

        public VMLoginPage()
        {
            this.LoginCommand = new Command(LoginCommandExecute);
        }

        #region Methods
        private void LoginCommandExecute(object obj)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new MainPage());
        }
        #endregion
    }
}

