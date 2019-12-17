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
    public partial class CreateNewCustomer
    {
        partial void CreateNewCustomer_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Escriba el código aquí.
            this.CustomerProperty = new Customer();
        }

        partial void CreateNewCustomer_Saved()
        {
            // Escriba el código aquí.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.CustomerProperty);
        }

        partial void CreateNewCustomer_Created()
        {
            //throw new NotImplementedException();
            this.SampleMessage = "En esta pantalla puede crear un nuevo cliente";
        }
        
            
        
    }
}