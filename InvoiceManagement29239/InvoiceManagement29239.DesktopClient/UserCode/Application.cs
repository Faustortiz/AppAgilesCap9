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
    public partial class Application
    {
        partial void CreateNewCustomer_CanRun(ref bool result)
        {
            result = this.User.HasPermission(Permissions.Can_Add_Customers);

        }

        partial void CreateNewEmployeesItem_CanRun(ref bool result)
        {
            result = this.User.HasPermission(Permissions.Can_Add_Employees);

        }

        partial void CreateNewInvoice_CanRun(ref bool result)
        {
            result = this.User.HasPermission(Permissions.Can_Add_Invoices);

        }

        partial void CreateNewOrderHeader_CanRun(ref bool result)
        {
            result = this.User.HasPermission(Permissions.Can_Add_Orders);

        }

        partial void CreateNewProduct_CanRun(ref bool result)
        {
            result = this.User.HasPermission(Permissions.Can_Add_Products);

        }

        partial void CustomerSetListDetail1_CanRun(ref bool result)
        {
            result = this.User.HasPermission(Permissions.Can_Add_Customers) &&
                     this.User.HasPermission(Permissions.Can_Delete_Customers) &&
                     this.User.HasPermission(Permissions.Can_Edit_Customers) &&
                     this.User.HasPermission(Permissions.Can_View_Customers) &&
                     this.User.HasPermission(Permissions.Can_Add_Orders) &&
                     this.User.HasPermission(Permissions.Can_Delete_Orders) &&
                     this.User.HasPermission(Permissions.Can_Edit_Orders) &&
                     this.User.HasPermission(Permissions.Can_View_Orders);

        }

        partial void CustomerSetListDetail_CanRun(ref bool result)
        {
            result = this.User.HasPermission(Permissions.Can_Add_Customers) &&
                     this.User.HasPermission(Permissions.Can_Delete_Customers) &&
                     this.User.HasPermission(Permissions.Can_Edit_Customers) &&
                     this.User.HasPermission(Permissions.Can_View_Customers);

        }

        partial void EditableProductSetGrid_CanRun(ref bool result)
        {
            result = this.User.HasPermission(Permissions.Can_Add_Products) &&
                     this.User.HasPermission(Permissions.Can_Delete_Products) &&
                     this.User.HasPermission(Permissions.Can_Edit_Products) &&
                     this.User.HasPermission(Permissions.Can_View_Products);

        }

        partial void EmployeeListDetails_CanRun(ref bool result)
        {
            result = this.User.HasPermission(Permissions.Can_Add_Employees) &&
                     this.User.HasPermission(Permissions.Can_Delete_Employees) &&
                     this.User.HasPermission(Permissions.Can_Edit_Employees) &&
                     this.User.HasPermission(Permissions.Can_View_Employees);

        }

        partial void InvoiceSetListDetail_CanRun(ref bool result)
        {
            result = this.User.HasPermission(Permissions.Can_Add_Invoices) &&
                     this.User.HasPermission(Permissions.Can_Delete_Invoices) &&
                     this.User.HasPermission(Permissions.Can_Edit_Invoices) &&
                     this.User.HasPermission(Permissions.Can_View_Invoices) &&
                     this.User.HasPermission(Permissions.Can_View_Orders);

        }

        partial void OrderHeaderSetListDetail_CanRun(ref bool result)
        {
            result = this.User.HasPermission(Permissions.Can_Add_Orders) &&
                     this.User.HasPermission(Permissions.Can_Delete_Orders) &&
                     this.User.HasPermission(Permissions.Can_Edit_Orders) &&
                     this.User.HasPermission(Permissions.Can_View_Orders) &&
                     this.User.HasPermission(Permissions.Can_Add_OrderDetails) &&
                     this.User.HasPermission(Permissions.Can_Delete_OrderDetails) &&
                     this.User.HasPermission(Permissions.Can_Edit_OrderDetails) &&
                     this.User.HasPermission(Permissions.Can_View_OrderDetails);
        }

        partial void SearchCustomerSet_CanRun(ref bool result)
        {
            result = this.User.HasPermission(Permissions.Can_View_Customers);

        }

        

        partial void SearchInvoiceSet_CanRun(ref bool result)
        {
            result = this.User.HasPermission(Permissions.Can_View_Invoices);

        }

        partial void SearchProductSet_CanRun(ref bool result)
        {
            result = this.User.HasPermission(Permissions.Can_View_Products);

        }
    }
}