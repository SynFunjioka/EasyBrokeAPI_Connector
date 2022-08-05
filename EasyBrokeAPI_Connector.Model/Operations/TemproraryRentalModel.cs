using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Model.Operations
{
    public enum en_TemporaryRentalPeriod { monthly, weekly, daily }
    public class TemproraryRentalModel : OperationModel
    {
        public TemproraryRentalModel(int amount, string formatted, string currency, en_TemporaryRentalPeriod period)
        {
            Type = en_SaleOrRentalType.temporary_rental.ToString();
            Amount = amount;
            FormattedAmount = formatted;
            Currency = currency;
            Period = period.ToString();
        }

        public TemproraryRentalModel(int amount, string formatted, string currency, string period)
        {
            Type = en_SaleOrRentalType.temporary_rental.ToString();
            Amount = amount;
            FormattedAmount = formatted;
            Currency = currency;
            Period = period;
        }

        public string Period { get; set; }
    }
}
