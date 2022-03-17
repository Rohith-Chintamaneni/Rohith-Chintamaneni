using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LowLevelDesign.SlotMachine
{
    public interface IRule
    {
        bool Evaluate(List<int> ls);
    }

    public class EvenNumberWinningLottery : IRule
    {
        public bool Evaluate(List<int> ls)
        {
            return ls.All(x => x % 2 == 0);
        }
    }

    public class SameNumberWinningLottery : IRule
    {
        public bool Evaluate(List<int> ls)
        {
             return !ls.Any(x => x != ls[0]);

        }
    }
}
