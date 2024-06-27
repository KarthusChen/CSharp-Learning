namespace EventsAndMultiCastDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();

            Player player1 = new Player("Linco");
            Player player2 = new Player("Karthus");
            Player player3 = new Player("Downey");
            

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is running, press any key to end the game...");

            Console.ReadLine();

            GameEventManager.TriggerGameOver();

        }
    }
}
