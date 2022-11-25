using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace FirstApp.Controls
{
    public class ExtendedListView : ListView
    {
        #region BindableProperty
        public static readonly BindableProperty ItemTapCommandProperty = BindableProperty
            .Create(
                nameof(ItemTapCommand),
                typeof(ICommand),
                typeof(ExtendedListView),
                null
            );

        public ICommand ItemTapCommand
        {
            get => (ICommand)GetValue(ItemTapCommandProperty);
            set => SetValue(ItemTapCommandProperty, value);
        }
        #endregion

        public ExtendedListView()
        {
            this.ItemTapped += OnItemTapped;
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (ItemTapCommand?.CanExecute(e.Item) == true)
                ItemTapCommand.Execute(e.Item);
        }
    }
}

