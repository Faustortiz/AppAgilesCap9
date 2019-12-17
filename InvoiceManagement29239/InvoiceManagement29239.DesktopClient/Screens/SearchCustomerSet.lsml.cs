using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO;
using System.Linq;
using System;

namespace LightSwitchApplication
{
    public partial class SearchCustomerSet
    {
        partial void ShowDetails_Execute()
        {
            // Escriba el código aquí.
            this.Application.ShowCustomerDetail(this.CustomerSet.SelectedItem.Id);
        }

        partial void ShowDetails_CanExecute(ref bool result)
        {
            // Escriba el código aquí.
            result = (this.CustomerSet.SelectedItem != null);

        }
    }
}