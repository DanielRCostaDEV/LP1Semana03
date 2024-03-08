using System;

public class Program
{
    [Flags]
    public enum Powers
    {
        Fly = 1,
        XRayVision = 2,
        SuperStrength = 4
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Number of players:");
        int n = int.Parse(Console.ReadLine());

        Powers[][] playersPowers = new Powers[n][];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nJogador {i + 1}:");
            Console.WriteLine("Powers? (separated by comma) [Fly, XRayVision, SuperStrength]:");
            string powersInput = Console.ReadLine().Trim().ToLower();
            string[] powers = powersInput.Split(',');
            playersPowers[i] = new Powers[powers.Length];

            for (int j = 0; j < powers.Length; j++)
            {
                switch (powers[j])
                {
                    case "fly":
                        playersPowers[i][j] = Powers.Fly;
                        break;
                    case "xrayvision":
                        playersPowers[i][j] = Powers.XRayVision;
                        break;
                    case "superstrength":
                        playersPowers[i][j] = Powers.SuperStrength;
                        break;
                }
            }
        }

        Console.WriteLine("\nEach player powers:");
        for (int i = 0; i < playersPowers.Length; i++)
        {
            Console.WriteLine($"\nPlayer {i + 1}:");
            foreach (Powers power in playersPowers[i])
            {
                Console.WriteLine(power);
            }

            if (Array.IndexOf(playersPowers[i], Powers.Fly) != -1 && Array.IndexOf(playersPowers[i], Powers.SuperStrength) != -1)
            {
                Console.WriteLine("Flying radiation!");
            }
        }
    }
}
