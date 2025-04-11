using MVVM.ViewModels;
using MVVM.Models;

namespace MVVM;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();
    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var viewModel = BindingContext as ContactsViewModel;
        if (e.CurrentSelection.FirstOrDefault() is Models.Contact selectedContact)
        {
            await viewModel.SelectContactCommand.ExecuteAsync(selectedContact);
            // Deselect item so that the user can tap again.
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}