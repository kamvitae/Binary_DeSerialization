using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_9_4_Binary_De_Serialization
{
    [Serializable]
    class Card
    {
        public Suits Suit { get; set; } 
        public Values Value { get; set; } 
        public string Name { get {
                            return $"{Value} of {Suit}";    } }
        public Card(Suits suit, Values value)
        {
            this.Suit = suit; 
            this.Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
