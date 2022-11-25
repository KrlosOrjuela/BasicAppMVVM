using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FirstApp.Interfaces;
using FirstApp.Services;
using FirstApp.ViewModels;
using FirstApp.Views;
using Xamarin.Forms;

namespace FirstApp
{
    public class VMHomePage : AppViewModel
    {
        private readonly ICourseService courseService;

        #region Binding Property
        public ObservableCollection<VMSection> CourseServices { get; set; }
        #endregion

        #region Commands
        public ICommand ItemSelectedCommand { get; }
        #endregion

        public VMHomePage()
        {
            this.courseService = new CourseService();
            var sections = courseService.GetCourseSections();
            CourseServices = new ObservableCollection<VMSection>();

            if (sections.Count > 0)
                sections.ForEach(s => CourseServices.Add(s));

            this.ItemSelectedCommand = new Command(ItemSelectedCommandExecute);
        }

        private void ItemSelectedCommandExecute(object obj)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new SectionDetailPage(obj as VMSection));
        }

        #region Methods

        #endregion
    }

}

