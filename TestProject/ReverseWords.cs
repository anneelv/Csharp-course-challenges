// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] smallChunks = pangram.Split(' ');
// // string result = "";
// string[] reversedPangram = new string[smallChunks.Length];
// int count = 0;

// foreach (string chunks in smallChunks)
// {
    
//     char[] reverseChunkChar = chunks.ToCharArray();
//     Array.Reverse(reverseChunkChar);
//     string result = new string(reverseChunkChar);
//     reversedPangram[count] = result;
//     count += 1;
    
//     // Console.Write($"{result} ");
// }

// // foreach (string words in reversedPangram)
// // {
// //     Console.WriteLine(words);
// // }

// string endResult = String.Join(" ", reversedPangram);
// Console.WriteLine(endResult);

// // OTHER OPTIONS
// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');

// //Step 2
// string[] newMessage = new string[message.Length];

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);



// SEPARATING ORDERS

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] orderIDs = orderStream.Split(',');

// foreach (string order in orderIDs)
// {
//     if (order.Length == 4)
//         Console.WriteLine(order);
//     else
//         Console.WriteLine($"{order}\t- Error");
// }