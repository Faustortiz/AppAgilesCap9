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
    public partial class CustomerDetail
    {
        partial void Customer_Loaded(bool succeeded)
        {
            // Escriba el código aquí.
            this.SetDisplayNameFromEntity(this.Customer);
        }

        partial void Customer_Changed()
        {
            // Escriba el código aquí.
            this.SetDisplayNameFromEntity(this.Customer);
        }

        partial void CustomerDetail_Saved()
        {
            // Escriba el código aquí.
            this.SetDisplayNameFromEntity(this.Customer);
        }
    }
}