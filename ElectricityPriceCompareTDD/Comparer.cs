using ElectricityPriceCompareTDD;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityPriceCompareTDD
{
    public enum ElectricityContractType
    {
        FixedPrice,
        MarketPrice
    }
    public class Comparer
    {
        public List<PriceDifference> ComparePrices(List<ElectricityPrice> exchangePrices, decimal fixedPrice)
        {
            List<PriceDifference> differences = new List<PriceDifference>();

            foreach (var exchangePrice in exchangePrices)
            {
                decimal differenceValue = Math.Abs((decimal)exchangePrice.Price - fixedPrice);
                ElectricityContractType cheaperContract = exchangePrice.Price < fixedPrice ? ElectricityContractType.MarketPrice : ElectricityContractType.FixedPrice;

                differences.Add(new PriceDifference(differenceValue, exchangePrice.StartDate, exchangePrice.EndDate, cheaperContract));
            }

            return differences;
        }

        public List<ElectricityPrice> DeserializeJson(string jsonData)
        {
            var jsonInput = JsonConvert.DeserializeObject<Dictionary<string, List<ElectricityPrice>>>(jsonData);
            return jsonInput["prices"];
        }
    }
}
