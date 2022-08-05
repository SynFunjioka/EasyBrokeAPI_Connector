using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Model.Operations
{
    public class SaleOrRentalModel : OperationModel
    {
        public SaleOrRentalModel(en_SaleOrRentalType type, int amount, string formatted, string currency, en_SaleOrRentalUnit unit)
        {
            Type = type.ToString();
            Amount = amount;
            FormattedAmount = formatted;
            Currency = currency;
            Unit = unit.ToString();
        }

        public SaleOrRentalModel(string type, int amount, string formatted, string currency, string unit)
        {
            Type = type;
            Amount = amount;
            FormattedAmount = formatted;
            Currency = currency;
            Unit = unit;
        }
        public string Unit { get; set; }
    }
}
