// // TEST PASS BY VALUE
// using System.Runtime.InteropServices;

// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c)
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }

// // TEST PASS BY REFERENCE
// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array)
// {
//     foreach (int a in array)
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = 0;
//     }
// }

// // TEST WITH STRINGS
// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// SetHealth(false);
// Console.WriteLine($"End: {status}");

// void SetHealth(bool isHealthy)
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy"); // This is overwriting the global status
//     Console.WriteLine($"Middle: {status}");
// }

// // void SetHealth(string status, bool isHealthy)
// // {
// //     status = (isHealthy ? "Healthy" : "Unhealthy"); // This is only replacing for a while
// //     Console.WriteLine($"Middle: {status}");
// // }