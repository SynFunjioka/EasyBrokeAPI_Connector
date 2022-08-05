using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Model.Operations
{
    public enum en_SaleOrRentalType { sale, rental, temporary_rental }
    public enum en_SaleOrRentalUnit { total, square_meter, hectare }
    public class OperationModel
    {
        public string Type { get; set; }
        public int Amount { get; set; }
        public string FormattedAmount { get; set; }
        public string Currency { get; set; }
    }
}
