// double usd = 23.73;
// int vnd = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

// int UsdToVnd(double usd)
// {
//     int rate = 23500;
//     return (int) (rate * usd);
// }

// double VndToUsd(int vnd)
// {
//     double rate = 23500;
//     return vnd / rate;
// }

// // =======================================================

// string input = "snake";
// string input2 = "there are snakes at the zoo";

// Console.WriteLine(input);
// Console.WriteLine(ReverseWord(input));

// Console.WriteLine(input2);
// Console.WriteLine(ReverseSentence(input2));

// string ReverseWord(string word)
// {
//     string result = "";
//     for (int i = word.Length - 1; i>= 0; i--)
//     {
//         result += word[i];
//     }

//     return result;
// }

// string ReverseSentence(string input2)
// {
//     string result = "";
//     string[] words = input2.Split(" ");
//     foreach(string word in words)
//     {
//         result += ReverseWord(word) + " ";
//     }

//     return result.Trim();
// }

// // =====================================================

// string[] words2 = {"racecar", "talented", "deified", "tent", "tenet"};

// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words2)
// {
//     Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }

// bool IsPalindrome(string word)
// {
//     int start = 0;
//     int end = word.Length - 1;

//     while (start < end)
//     {
//         if (word[start] != word[end])
//         {
//             return false;
//         }
//         start++;
//         end--;
//     }
//     return true;
// }

// // ========================================================

// int target = 30;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[,] result = TwoCoins(coins, target);

// if (result.Length == 0)
// {
//     Console.WriteLine("No two coins make change");
// }
// else
// {
//     Console.WriteLine("Change found at positions:");
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         if (result[i,0] == -1)
//         {
//             break;
//         }
//         Console.WriteLine($"{result[i,0]}, {result[i,1]}");
//     }
// }

// int[,] TwoCoins(int[] coins, int target)
// {
//     int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
//     int count = 0;

//     for (int curr = 0; curr < coins.Length; curr++)
//     {
//         for (int next = curr + 1; next < coins.Length; next++)
//         {
//             if (coins[curr] + coins[next] == target)
//             {
//                 result[count, 0] = curr;
//                 result[count, 1] = next;
//                 count++;
//             }
//             if (count == result.GetLength(0))
//             {
//                 return result;
//             }
//         }
//     }
//     return (count == 0) ? new int[0,0] : result;
// }

// // ============================================================

