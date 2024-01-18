// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// string? response = Console.ReadLine();

// if (response != null)
// {
//     if (ShouldPlay(response))
//     {
//         PlayGame();
//     }
// }

// void PlayGame()
// {
//     var play = true;

//     while(play)
//     {
//         var target = random.Next(1, 6);
//         var roll = random.Next(1, 7);

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(roll, target));
//         Console.WriteLine();
//         Console.WriteLine("\nPlay again? (Y/N)");
//         response = Console.ReadLine();
//         if (response != null)
//         {
//             play = ShouldPlay(response);
//         }
//     }
// }

// bool ShouldPlay(string response)
// {
//     // Retrieve user input and determine if the user wants to play again
//     if (response != null)
//     {
//         return (response.ToUpper() == "Y") ? true : false;
//     }
//     return false;
// }

// string WinOrLose(int roll, int target)
// {
//     // Determine if the player has won or lost
//     return (roll > target) ? "You win!" : "You lose!";
// }

