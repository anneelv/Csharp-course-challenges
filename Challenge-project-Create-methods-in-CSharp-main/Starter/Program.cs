// NOTE: There's a bug when the speed is + 3 related to how the Food should regenerate

using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;
int speed = 1;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = {"('-')", "(^-^)", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

// index of the previous food
int previousFood = 0;

InitializeGame();
while (!shouldExit) 
{

    Move(speed: CheckPlayerAppearance());
    CheckFood();
    if (EndingGame())
        break;
}


// =====================================================================================

// Returns true if the Terminal was resized 
bool TerminalResized() 
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood() 
{
    previousFood = food;
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer() 
{
    player = states[previousFood];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer() 
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move(bool keyInput = false, int speed = 1) 
{
    int lastX = playerX;
    int lastY = playerY;
    
    switch (Console.ReadKey(keyInput).Key) 
    {
        case ConsoleKey.UpArrow:
            playerY--; 
            CheckFood();
            break;
		case ConsoleKey.DownArrow: 
            playerY++; 
            CheckFood();
            break;
		case ConsoleKey.LeftArrow:  
            playerX-=speed; 
            CheckFood(speed);
            break;
		case ConsoleKey.RightArrow: 
            playerX+=speed; 
            CheckFood(-speed);
            break;
		case ConsoleKey.Escape:     
            shouldExit = true;
            Console.Clear();
            break;
        default: //terminate game when detect nondirectional input
            shouldExit = true; 
            Console.Clear();
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++) 
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame() 
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}

// Clear the console and ending the game when terminal resized
bool EndingGame()
{
    if (TerminalResized())
    {
        Console.Clear();
        Console.WriteLine("Console was resized. Program exiting.");
        return true;
    }
    return false;
}

// Check current player appearance and update movement accordingly
int CheckPlayerAppearance()
{
    switch (player)
    {
        case "('-')":
            return speed = 1;
            // break;
        case "(^-^)":
            return speed = 3;
            // break;
        case "(X_X)":
            FreezePlayer();
            break;
    }
    return speed = 1;
}

void CheckFood(int position = 0)
{
    if (foodX == playerX+position && foodY == playerY)
    {
        ShowFood();
        ChangePlayer();
    }
}