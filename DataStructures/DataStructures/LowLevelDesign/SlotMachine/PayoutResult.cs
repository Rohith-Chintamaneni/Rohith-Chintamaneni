using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LowLevelDesign.SlotMachine
{
    public sealed class PayoutResult
    {
        public bool result { get; set; }
        public PayoutResult(bool val)
        {
            result = val;
        }

        public override string ToString()
        {
            // "Win" or "Loose"
            return result ? "Win" : "Loose";
        }
	}
}
