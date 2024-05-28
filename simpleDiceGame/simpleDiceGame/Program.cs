internal class Program
{
    private static void Main(string[] args)
    {

        int playerRandomNumber,enemyRandomNumber,playerPoints=0 ,enemyPoints=0;
        Random random = new Random();
        for (int i = 0; i < 10; i++) 
        {
            Console.WriteLine($"\nthe {i+1} game");
            Console.WriteLine("press any key to roll the dice");
            Console.ReadKey( true);
            playerRandomNumber = random.Next(1,7);
            Console.WriteLine($"\nyou rolled a {playerRandomNumber}");
            Console.WriteLine(".....");
            System.Threading.Thread.Sleep(1000);
            enemyRandomNumber = random.Next(1,7);
            Console.WriteLine($"your enemy rolled a {enemyRandomNumber}");
            if (playerRandomNumber > enemyRandomNumber) { Console.WriteLine("you win"); playerPoints++; }
            else if (enemyRandomNumber > playerRandomNumber) { Console.WriteLine("enemy win"); enemyPoints++; }
            else Console.WriteLine("draw"); 
        }
        Console.WriteLine("\n\n\n.....");
        System.Threading.Thread.Sleep(1000);
        if(playerPoints>enemyPoints) { Console.WriteLine("you win the game"); }
        else if (playerPoints == enemyPoints) { Console.WriteLine("draw"); }
        else { Console.WriteLine("enemy won the game"); };
        Console.ReadKey();
    }

}