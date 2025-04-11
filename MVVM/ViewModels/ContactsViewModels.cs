using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.Services;
using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {
        public ObservableCollection<Models.Contact> Contacts => ContactService.Contacts;

        [RelayCommand]
        public async Task SelectContactAsync(Models.Contact selectedContact)
        {
            if (selectedContact == null)
                return;

            ContactService.CurrentContact = selectedContact;

            await Shell.Current.GoToAsync("//contactdetails", true);
        }

        [RelayCommand]
        public async Task GoToAddContactAsync()
        {
            await Shell.Current.GoToAsync("//addcontact");
        }
    }
}
