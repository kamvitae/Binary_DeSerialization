using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_9_4_Binary_De_Serialization
{
    [Serializable]
    class CardComparer_bySuit_thenByValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Suit > y.Suit)
                return 1;
            else if (x.Suit < y.Suit)
                return -1;
            else
                if (x.Value > y.Value)
                return 1;
            else if (x.Value < y.Value)
                return -1;
            return 0;

            /*
             * czytelniej:
             * 
            if (x.Suit > y.Suit)
                return 1;
            if (x.Suit < y.Suit)
                return -1;
            
            if (x.Value > y.Value)
                return 1;
            if (x.Value < y.Value)
                return -1;

            return 0;
             */
        }
    }
}
