using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityPriceCompareTDD
{
    public class ElectricityPrice
    {
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    public class PriceDifference
    {
        public decimal PriceDifferenceValue { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ElectricityContractType CheaperContract { get; set; }

        public PriceDifference(decimal priceDifference, DateTime startDate, DateTime endDate, ElectricityContractType cheaperContract)
        {
            PriceDifferenceValue = priceDifference;
            StartDate = startDate;
            EndDate = endDate;
            CheaperContract = cheaperContract;
        }
    }
}
