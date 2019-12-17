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
    public partial class CreateNewInvoice
    {
        partial void CreateNewInvoice_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Escriba el código aquí.
            this.InvoiceProperty = new Invoice();
        }

        partial void CreateNewInvoice_Saved()
        {
            // Escriba el código aquí.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.InvoiceProperty);
        }
    }
}