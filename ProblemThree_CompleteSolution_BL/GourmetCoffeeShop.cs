using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
   public class GourmetCoffeeShop : GourmetShop, ITaxCompute
    {

        public int GId;
        public string GName;
        public double GQuantity;
        public GourmetCoffeeShop(int GId,string GName, double GQuantity)
        {
            this.GId = GId;
            this.GName = GName;
            this.GQuantity = GQuantity;
        }



         List<GourmetCoffeeShop> coffeePriceDict = new List<GourmetCoffeeShop>();
        public GourmetCoffeeShop()
        {
            coffeePriceDict.Add(new GourmetCoffeeShop(1, "Arabica Coffee Powder Pre-Packed Container", 4));
            coffeePriceDict.Add(new GourmetCoffeeShop(2, "Arabica Coffee Powder Pre-Packed Container", 2));
        }
    }
}
