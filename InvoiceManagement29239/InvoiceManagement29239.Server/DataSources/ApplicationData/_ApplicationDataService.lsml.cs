using Microsoft.LightSwitch.Security.Server;
using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void CustomerSet_CanDelete(ref bool result)
        {
           result = this.Application.User.HasPermission(Permissions.Can_Delete_Customers);
        }

        partial void CustomerSet_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Add_Customers);
        }

        partial void CustomerSet_CanRead(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_View_Customers);
        }

        partial void CustomerSet_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Edit_Customers);
        }

        partial void OrderHeaderSet_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Delete_Orders);
        }

        partial void OrderHeaderSet_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Add_Orders);
        }

        partial void OrderHeaderSet_CanRead(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_View_Orders);
        }

        partial void OrderHeaderSet_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Edit_Orders);
        }

        partial void OrderDetailSet_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Delete_OrderDetails);
        }

        partial void OrderDetailSet_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Add_OrderDetails);
        }

        partial void OrderDetailSet_CanRead(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_View_OrderDetails);
        }

        partial void OrderDetailSet_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Edit_OrderDetails);
        }

        partial void ProductSet_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Delete_Products);
        }

        partial void ProductSet_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Add_Products);
        }

        partial void ProductSet_CanRead(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_View_Products);
        }

        partial void ProductSet_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Edit_Products);
        }

        partial void InvoiceSet_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Delete_Invoices);
        }

        partial void InvoiceSet_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Add_Invoices);
        }

        partial void InvoiceSet_CanRead(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_View_Invoices);
        }

        partial void InvoiceSet_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Edit_Invoices);
        }
    }
}