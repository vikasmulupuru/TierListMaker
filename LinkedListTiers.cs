using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierListMaker
{
    public class LinkedListTiers
    {
        public Tier head;

        public void addTier(Tier newTier)
        {
            Tier current = head;
            if (current == null)
            {
                head = newTier;
            } 
            else
            {
                while (head.nextTier != null)
                {
                    current = current.nextTier;
                }
                current.nextTier = newTier;
            }
        }

        public int ListLength()
        {
            int length = 0;
            Tier current;

            for(current = head; current != null; current = current.getnextTier())
            {
                length++;
            }

            return length;
        }
    }
}
