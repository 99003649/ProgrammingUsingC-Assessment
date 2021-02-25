using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop
    {
        public int OId;
        public string OName;
        public int OQuantity;
        public GourmetOrganicShop(int OId, string OName, int OQuantity)
        {
            this.OId = OId;
            this.OName = OName;
            this.OQuantity = OQuantity;
        }



         List<GourmetOrganicShop> organicPriceDict = new List<GourmetOrganicShop>();
        public GourmetOrganicShop()
        {
            organicPriceDict.Add(new GourmetOrganicShop(1, "Non Polished Tur Dal", 2));
            organicPriceDict.Add(new GourmetOrganicShop(2, "Polished Tur Dal", 4));
        }

    }
}
