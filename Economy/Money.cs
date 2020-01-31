using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomelessModel.Economy
{
    [Serializable]
    public class Money : AbstractResourse
    {
        public double Count { get; set; }

        public virtual string Name { get; protected set; }

        /// <summary>
        /// Коэффициент перевода
        /// </summary>
        protected int conversionFactor;

        //public virtual void ConvertToOtherMoney(out Money newMoney)
        //{
        //    newMoney = new Money();
        //    newMoney.Count = this.Count * conversionFactor;   // подумать и написать
        //}

        public Money()
        {
            AllowedOperations = AllowedOperations.All;
        }
    }
}
