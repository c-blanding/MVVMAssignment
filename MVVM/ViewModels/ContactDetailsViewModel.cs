using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Contact = MVVM.Models.Contact;
using MVVM.Services;

namespace MVVM.ViewModels
{
    public partial class ContactDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private Contact selectedContact;

        [ObservableProperty]
        private bool isEditing;

        public ContactDetailsViewModel()
        {
            SelectedContact = ContactService.CurrentContact;
        }

        [RelayCommand]
        public void Edit()
        {
            IsEditing = true;
        }

        [RelayCommand]
        public async Task SaveContactAsync()
        {
            IsEditing = false;
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        public async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
