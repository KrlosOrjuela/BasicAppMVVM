using System;
using FirstApp.Models;
using Xamarin.Forms;

namespace FirstApp.ViewModels
{
    public class VMSection : AppViewModel
    {
        private readonly NavigationPage navigationPage;

        #region Binding Property

        private int _idValue;
        public int Id
        {
            get { return this._idValue; }
            private set { SetProperty(ref _idValue, value); }
        }

        private string _titleValue;
        public string Title
        {
            get { return this._titleValue; }
            private set { SetProperty(ref _titleValue, value); }
        }

        private string _subtitleValue;
        public string Subtitle
        {
            get { return this._subtitleValue; }
            private set { SetProperty(ref _subtitleValue, value); }
        }

        private string _videoUrlValue;
        public string VideoUrl
        {
            get { return this._videoUrlValue; }
            private set { SetProperty(ref _videoUrlValue, value); }
        }

        private string _transcriptValue;
        public string Transcript
        {
            get { return this._transcriptValue; }
            private set { SetProperty(ref _transcriptValue, value); }
        }
        #endregion

        public VMSection(Section section, NavigationPage navigation = null)
        {
            this.Id = section.Id;
            this.Title = section.Title;
            this.Subtitle = section.Subtitle;
            this.VideoUrl = section.VideoUrl;
            this.Transcript = section.Transcript;
            this.navigationPage = navigation;
        }
    }
}

