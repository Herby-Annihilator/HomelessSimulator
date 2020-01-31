using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomelessModel.Economy
{
    [Serializable]
    public class Dollar : Money
    {
        public Dollar()
        {
            Name = "Dollar";
            conversionFactor = 1;
            Count = 0;

            // картинки и еще чего-нибудь

        }
    }
}
