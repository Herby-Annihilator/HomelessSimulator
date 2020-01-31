using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomelessModel.Economy
{
    public class Money : AbstractResourse
    {
        public double Count { get; set; }
        public override double ConvertToMoney(AbstractResourse resourse)
        {
            throw new NotImplementedException();
        }

        public virtual string Name { get; protected set; }

        protected int conversionFactor;

        public virtual void ConvertToOther(out Money newMoney)
        {
            newMoney = new Money();
            newMoney.Count = this.Count * conversionFactor;   // подумать и написать
        }
    }
}
