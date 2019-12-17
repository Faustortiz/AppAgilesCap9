using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class Invoice
    {
        private decimal Amount_Compute(decimal result)
        {

            if (this.OrderHeader != null)
            {
                decimal totalExpense = 0;
                foreach (var det in this.OrderHeader.OrderDetailCollection)
                {
                    totalExpense += (det.UnitPrice * det.Quantity) - det.Discount;
                }
                result = totalExpense;
            }
            else
            {
                result = 0;
            }
            return (result);


        }

        private void TotalAmount_Compute(decimal result)
        {
            // Establece el resultado en el valor del campo deseado
            if (this.Taxes != null)
                result = this.Amount + this.Taxes.Value;
        }
    }
}