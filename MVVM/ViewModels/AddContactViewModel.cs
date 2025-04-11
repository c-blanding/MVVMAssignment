using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVVM.Models;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {
        [ObservableProperty]
        string name;

        [ObservableProperty]
        string email;

        [ObservableProperty]
        string phoneNumber;

        [ObservableProperty]
        string description;

        public AddContactViewModel()
        {
            
        }

        [RelayCommand]
        public async Task SaveContactAsync()
        {
            
            var newContact = new Models.Contact
            {
                Name = Name,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Description = Description
            };

            ContactService.Contacts.Add(newContact);

            Name = Email = PhoneNumber = Description = string.Empty;

            await Shell.Current.GoToAsync("//contacts");
        }
    }

}
