using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Models;

namespace MVVM.Services
{
    public static class ContactService
    {
        public static ObservableCollection<Models.Contact> Contacts { get; } = new ObservableCollection<Models.Contact>();

        // Add a property to hold the current selected contact.
        public static Models.Contact CurrentContact { get; set; }
    }

}
