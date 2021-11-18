using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierListMaker
{
    public class Tier
    {
        public string name = "";
        TierListItem head = new TierListItem();
        public Tier nextTier;
        
        public Tier ()
        {

        }
        public Tier (string Name)
        {
            this.name = Name;
        }

        public Tier getnextTier()
        {
            return nextTier;
        }

        public void setNextTier(Tier next)
        {
            this.nextTier = next;
        }

        TierListItem getHead()
        {
            return head;
        }

        void setHead(TierListItem inputtedHead)
        {
            this.head = inputtedHead;
        }
    }
}
