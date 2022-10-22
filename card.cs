using System;


namespace Unit02.Game
{
        /// <summary>
        /// A deck of cards worth different points depending on the random card drawn
        /// 
        /// The responsibility of card is to keep track of its currently drawn value and the points its
        /// worth.
        /// </summary> 
        
        public class Card
        {
          public int value;
        
            /// <summary>
            /// Constructs a new card.
            /// </summary>
            public Card()
            {
                Shuffle();
            }
            public int Shuffle()
            {
                Random c = new Random();
                value = c.Next(1, 14);     
                return value;
            }

            
        }    
}

