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
    public partial class CreateNewOrderHeader
    {
        partial void CreateNewOrderHeader_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Escriba el código aquí.
            this.OrderHeaderProperty = new OrderHeader();
        }

        partial void CreateNewOrderHeader_Saved()
        {
            // Escriba el código aquí.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.OrderHeaderProperty);
        }
    }
}