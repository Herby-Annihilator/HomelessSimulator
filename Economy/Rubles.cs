using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomelessModel.Economy
{
    [Serializable]
    public class Rubles : Money
    {
        public Rubles()
        {
            Name = "Rubles";
            conversionFactor = 65; // 0.65
            Count = 0;

            // картинки и еще чего-нибудь
        }
    }
}
