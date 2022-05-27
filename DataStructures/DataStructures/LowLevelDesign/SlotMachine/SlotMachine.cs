using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LowLevelDesign.SlotMachine
{
    public class SlotMachine : ISlotMachine
    {
        // private PayoutResult result;
        private int rollersize;
        private List<IRule> rules;
        private List<bool> ruleresults;
        public SlotMachine(int rsize, List<IRule> rrules)
        {

            rollersize = rsize;
            rules = rrules;
            ruleresults = new List<bool>();
        }
        public PayoutResult Play()
        {

            var rollerresults = new List<int>();
            var random = new Random();

            for (int i = 0; i < rollersize; i++)
            {
                rollerresults.Add(random.Next(0, 9));
            }

            rules.ForEach(x =>ruleresults.Add(x.Evaluate(rollerresults))); 

           
            return new PayoutResult(ruleresults.Any(x=>x));


        }

        public bool SameNumberWinningLottery(List<int> ls)
        {
            return !ls.Any(x => x != ls[0]);
           
            

        }


        public bool EvenNumberWinningLottery(List<int> ls)
        {

            return ls.Any(x => x % 2 == 0);

        }
    }

    public interface ISlotMachine
    {
        PayoutResult Play();
    }

  
}
