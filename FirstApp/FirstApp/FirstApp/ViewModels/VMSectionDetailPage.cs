using System;
using LibVLCSharp.Shared;

namespace FirstApp.ViewModels
{
    public class VMSectionDetailPage : AppViewModel
    {
        #region Binding Property
        private string _titleValue;
        public string Title
        {
            get { return this._titleValue; }
            set { SetProperty(ref _titleValue, value); }
        }

        private string _videoUrlValue;
        public string VideoUrl
        {
            get { return this._videoUrlValue; }
            set { SetProperty(ref _videoUrlValue, value); }
        }

        private string _transcriptValue;
        public string Transcript
        {
            get { return this._transcriptValue; }
            set { SetProperty(ref _transcriptValue, value); }
        }

        private LibVLC _libVLC;
        public LibVLC LibVLC
        {
            get => _libVLC;
            private set => SetProperty(ref _libVLC, value);
        }

        private MediaPlayer _mediaPlayer;
        public MediaPlayer MediaPlayer
        {
            get => _mediaPlayer;
            private set => SetProperty(ref _mediaPlayer, value);
        }

        #endregion

        public VMSectionDetailPage()
        {
        }

        #region Methods

        /// <summary>
        /// Initialize LibVLC and playback when page appears
        /// </summary>
        public void OnAppearing()
        {
            if (!string.IsNullOrEmpty(VideoUrl))
            {
                Core.Initialize();
                LibVLC = new LibVLC();
                var media = new Media(LibVLC, new Uri(VideoUrl));
                MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
                media.Dispose();
                MediaPlayer.Play();
            }
            else
                App.Current.MainPage.DisplayAlert("Error", "Url Inavlida", "Entendido");

        }

        public void OnDisappearing()
        {
            MediaPlayer.Stop();
        }

        #endregion



    }
}

