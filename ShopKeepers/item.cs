/* **************************************************
* ShopKeepers - Item v0.1.0
* Author: Joel Leckie
* Created: Sep. 2023
*  v0.1.0 - Created item class.
 ************************************************** */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopKeepers
{
    public enum coinType
    {
        Copper, Silver, Gold, Electrum, Platinum
    };

    internal class item
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private string category;
        public string Category { get { return category; } set { category = value; } }

        private int cost;
        public int Cost { get { return cost; } set { cost = value; }  }

        private coinType coinage;
        public coinType Coinage { get { return coinage; } set { coinage = value; } }
        public string CoinType { get { return CoinSymbol(coinage); } }

        private int weight;
        public int Weight { get { return weight; } set { weight = value; } }

        private string description;
        public string Description { get { return description; } set {  description = value; } }

        private List<string> tags;
        public List<string> Tags { get {  return tags; } set { tags = value;} }

        public item(string name, int cost, coinType coinage, int weight, string description, List<string> tags)
        {
            this.name = name;
            this.cost = cost;
            this.coinage = coinage;
            this.weight = weight;
            this.description = description;
            this.tags = tags;
        }

        public static string CoinSymbol(coinType coinage)
        {
            string symbol = "NF";
            switch (coinage)
            {
                case coinType.Copper:
                    symbol = "CP";
                    break;
                case coinType.Silver:
                    symbol = "SP";
                    break;
                case coinType.Gold:
                    symbol = "GP";
                    break;
                case coinType.Electrum:
                    symbol = "EP";
                    break;
                case coinType.Platinum:
                    symbol = "PP";
                    break;
            }
            return symbol;
        }
    }
}
