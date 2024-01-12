// // CHALLENGE 1
// /* string? input;
// int value = 0;
// bool validInput = false;

// Console.Write("Enter an integer value between 5 and 10: ");
// do 
// {
//     input = Console.ReadLine();
//     if (input != null)
//     {
//         validInput = int.TryParse(input, out value);
//         if (validInput == true)
//         {
//             if ((value >= 5) && (value <= 10))
//                 validInput = true;
//             else if ((value < 5) || (value > 10))
//             {
//                 Console.WriteLine($"You entered {value}. Please enter a number between 5 and 10.");
//                 validInput = false;
//             }
//         }
//         else
//             Console.WriteLine("Sorry, you entered an invalid number. Please try again.");
//     }

// } while (validInput == false);

// Console.WriteLine($"Your input value ({value}) has been accepted."); */

// // CHALLENGE 2

// /* string? input;
// bool validInput = false;

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// do 
// {
//     input = Console.ReadLine();
//     if (input != null)
//     {
//         input = input.Trim();
//         if (input.ToLower() == "administrator" || input.ToLower() == "manager" || input.ToLower() == "user")
//         {
//             validInput = true;
//         }
//         else
//             Console.WriteLine($"The role name that you entered, \"{input}\" is not valid. Enter your role name (Administrator, Manager, or User)");

//     }
// } while (validInput == false);

// Console.WriteLine($"Your input value ({input}) has been accepted."); */

// // CHALLENGE 3

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int periodLocation = -1;
// string tem = "";

// for (int i = 0; i < myStrings.Length; i++)
// {
//     // Console.WriteLine(myStrings[i].IndexOf("."));
//     periodLocation = myStrings[i].IndexOf(".");

//     if (periodLocation != -1)
//     {
//         tem = myStrings[i];
//         Console.WriteLine(tem.Remove(periodLocation).TrimStart());
//         while (periodLocation != -1)
//         {
           
//                 periodLocation += 1;
//                 tem = tem.Substring(periodLocation).TrimStart();
//                 periodLocation = tem.IndexOf(".");
//                 if (periodLocation == -1)
//                 {
//                     Console.WriteLine(tem.TrimStart());
//                     break;
//                 }
//                 else
//                 {
//                     Console.WriteLine(tem.Remove(periodLocation).TrimStart());
//                     // Console.WriteLine(periodLocation);

//                 }
            
//         }
//     }
//     else
//     {
//         Console.WriteLine(myStrings[i]);
//         // periodLocation = -1;
//     }
// }

// // BETTER OPTION

// // string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// // int stringsCount = myStrings.Length;

// // string myString = "";
// // int periodLocation = 0;

// // for (int i = 0; i < stringsCount; i++)
// // {
// //     myString = myStrings[i];
// //     periodLocation = myString.IndexOf(".");

// //     string mySentence;

// //     // extract sentences from each string and display them one at a time
// //     while (periodLocation != -1)
// //     {

// //         // first sentence is the string value to the left of the period location
// //         mySentence = myString.Remove(periodLocation);

// //         // the remainder of myString is the string value to the right of the location
// //         myString = myString.Substring(periodLocation + 1);

// //         // remove any leading white-space from myString
// //         myString = myString.TrimStart();

// //         // update the comma location and increment the counter
// //         periodLocation = myString.IndexOf(".");

// //         Console.WriteLine(mySentence);
// //     }
 
// //     mySentence = myString.Trim();
// //     Console.WriteLine(mySentence);
// // }