using System;
using System.Threading;

class SnackGame
{
    static int playerX = 10; // Initial X position of the player
    static int playerY = 10; // Initial Y position of the player
    static int snackX = 5;   // Initial X position of the snack
    static int snackY = 5;   // Initial Y position of the snack
    static int score = 0;    // Player's score
    static bool gameOver = false;

    static void Main(string[] args)
    {
        Console.CursorVisible = false; // Hide the cursor
        Random random = new Random();

        // Set initial snack position
        PlaceSnack(random);

        while (!gameOver)
        {
            DrawGame();
            HandleInput();
            CheckCollision();

            // Add a small delay to control game speed
            Thread.Sleep(100);
        }

        Console.Clear();
        Console.WriteLine("Game Over! Your final score: " + score);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void DrawGame()
    {
        Console.Clear();

        // Draw the player
        Console.SetCursorPosition(playerX, playerY);
        Console.Write("@");

        // Draw the snack
        Console.SetCursorPosition(snackX, snackY);
        Console.Write("*");

        // Display the score
        Console.SetCursorPosition(0, 0);
        Console.Write("Score: " + score);
    }

    static void HandleInput()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (playerY > 1) playerY--;
                    break;
                case ConsoleKey.DownArrow:
                    if (playerY < Console.WindowHeight - 2) playerY++;
                    break;
                case ConsoleKey.LeftArrow:
                    if (playerX > 0) playerX--;
                    break;
                case ConsoleKey.RightArrow:
                    if (playerX < Console.WindowWidth - 2) playerX++;
                    break;
                case ConsoleKey.Q:
                    gameOver = true;
                    break;
            }
        }
    }

    static void CheckCollision()
    {
        if (playerX == snackX && playerY == snackY)
        {
            score++;
            Random random = new Random();
            PlaceSnack(random);
        }
    }

    static void PlaceSnack(Random random)
    {
        snackX = random.Next(0, Console.WindowWidth - 2);
        snackY = random.Next(1, Console.WindowHeight - 2);
    }
}