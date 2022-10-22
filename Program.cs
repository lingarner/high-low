using Unit02.Game;


namespace Unit02
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static int Main(string[] args)
        {
            Director d = new Director();
            d.StartGame();
            return 0;
        }
    }
}

