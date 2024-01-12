// // int invoiceNumber = 1201;
// // decimal productShares = 25.4568m;
// // decimal subtotal = 2750.00m;
// // decimal taxPercentage = .15825m;
// // decimal total = 3185.19m;

// // Console.WriteLine($"Invoice Number: {invoiceNumber}");
// // Console.WriteLine($"    Shares: {productShares:N3} Product");
// // Console.WriteLine($"    Sub Total: {subtotal:C}");
// // Console.WriteLine($"        Tax: {taxPercentage:P2}");
// // Console.WriteLine($"    Total Billed: {total:C}");

// // string paymentId = "769C";
// // string payeeName = "Mr. Stephen Ortega";
// // string paymentAmount = "$5,000.00";

// // var formattedLine = paymentId.PadRight(6, '-');
// // formattedLine += payeeName.PadRight(24, '-');
// // formattedLine += paymentAmount.PadLeft(10);

// //  Console.WriteLine("1234567890123456789012345678901234567890");
// //  Console.WriteLine(formattedLine);

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// var formatCurrentReturn = $"{currentReturn:P2}";
// decimal currentProfit = 55000000.0m;
// var formatCurrentProfit = $"{currentProfit:N2}";
// var formatCurrentProfit2 = $"{formatCurrentProfit:C}";

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// var formatNewReturn = $"{newReturn:P2}";
// decimal newProfit = 63000000.0m;
// var formatNewProfit = $"{newProfit:N2}";
// var formatNewProfit2 = $"{formatNewProfit:C}";

// Console.WriteLine($"Dear {customerName}");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {formatCurrentReturn}\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}");

// Console.WriteLine("Here's a quick comparison:\n");

// var compare1 = currentProduct.PadRight(20);
// compare1 += formatCurrentReturn.PadRight(10);
// compare1 += formatCurrentProfit2.PadLeft(15);

// var compare2 = newProduct.PadRight(20);
// compare2 += formatNewReturn.PadRight(10);
// compare2 += formatNewProfit2.PadLeft(15);

// Console.WriteLine(compare1);
// Console.WriteLine(compare2);

// // OTHER OPTION

// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);