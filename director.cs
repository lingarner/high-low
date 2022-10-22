using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        List<int> cards = new List<int>();
        string userChoice = "";
        bool _isPlaying = true;

        Card test;
        int oldCard = 0;
        int newCard = 0;
        int points = 300;
        string again = "";


        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            Card card = new Card();
            newCard = card.Shuffle();
            oldCard = card.Shuffle();

        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they think the next card is going to be higher or lower
        /// </summary>
        public void GetInputs()
        {
            Console.WriteLine(oldCard);
            Console.Write("Higher or lower? [h/l]: ");
            userChoice = Console.ReadLine(); 
            
            Console.WriteLine(newCard);
            _isPlaying = (userChoice == "h" || userChoice == "l");

        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }
            
            if(userChoice == "h")
            {
                Higher();
            }

            else if (userChoice == "l")
            {
                Lower();
            }

            


        }

        public int Higher()
        {
            if(newCard > oldCard){
                points += 100;
            }
            else if(newCard < oldCard)
            {
                points -= 75;
            }

        

            return points;
        }

        public int Lower()
        {
            if (newCard < oldCard)
            {
                points += 100;
            }
            else if (newCard > oldCard)
            {
                points -= 75;
            }

            return points;
        }




        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {

            if (!_isPlaying)
            {
                return;
            }

            Console.WriteLine($"Your score is: {points}");
            Console.Write($"Play again? [y/n]: ");
            again = Console.ReadLine();

            Console.Write("\n");


            if(again == "n")
            {
                _isPlaying = false;
            }
            else if (again == "y")
            {
                if(points <= 0){
                    Console.WriteLine("Game Over");
                    _isPlaying = false;
                }
            }
        }
        
            
    }
}


