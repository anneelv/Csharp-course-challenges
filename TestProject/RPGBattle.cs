// int heroHP = 10;
// int monsterHP = 10;
// string turn = "Hero";

// Random random = new();
// int attack = random.Next(1, 11);

// do 
// {
//     switch (turn)
//     {
//         case "Hero":
//             monsterHP -= attack;
//             Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHP} health left");
//             turn = "Monster";
//             break;
//         case "Monster":
//             heroHP -= attack;
//             Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHP} health left");
//             turn = "Hero";
//             break;
//     }

//     attack = random.Next(1, 11);
// }while ((heroHP > 0) && (monsterHP > 0));

// // while ((heroHP > 0) && (monsterHP > 0))
// // {
// //     attack = random.Next(1, 11);
// //     switch (turn)
// //     {
// //         case "Hero":
// //             monsterHP -= attack;
// //             Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHP} health left");
// //             turn = "Monster";
// //             break;
// //         case "Monster":
// //             heroHP -= attack;
// //             Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHP} health left");
// //             turn = "Hero";
// //             break;
// //     }
// // }

// if (heroHP <= 0)
//     Console.WriteLine("Monster wins!");
// else if (monsterHP <= 0)
//     Console.WriteLine("Hero wins!");


