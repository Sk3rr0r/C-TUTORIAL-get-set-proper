// See https://aka.ms/new-console-template for more information
float firstFlt, secondFlt;
string userName, userNum;

Console.Write("Enter first number: ");
userNum = Console.ReadLine();
firstFlt = float.Parse(userNum);

Console.Write("Enter second number: ");
userNum = Console.ReadLine();
secondFlt = int.Parse(userNum);

Console.WriteLine(firstFlt + secondFlt);


Console.Write("Enter your name: ");
userName = Console.ReadLine();

Console.Write("Enter your birth year: ");
userNum = Console.ReadLine();
firstFlt = int.Parse(userNum);

Console.WriteLine($"Hello, {userName}! You are {2025 - firstFlt} years old.");

Console.Write("Enter the temperature in celsius: ");
userNum = Console.ReadLine();
firstFlt = int.Parse(userNum);
Console.WriteLine($"{firstFlt} Celcius is {firstFlt + 273} Kelvin.");

Console.WriteLine($"{firstFlt} Celcius is {(firstFlt * 9 / 5) + 32} Farenheit.");

Console.Write("Enter first number: ");
userNum = Console.ReadLine();
firstFlt = int.Parse(userNum);

Console.Write("Enter second number: ");
userNum = Console.ReadLine();
secondFlt = int.Parse(userNum);

Console.WriteLine($"{firstFlt} + {secondFlt} = {firstFlt + secondFlt}");
Console.WriteLine($"{firstFlt} - {secondFlt} = {firstFlt - secondFlt}");
Console.WriteLine($"{firstFlt} * {secondFlt} = {firstFlt * secondFlt}");
Console.WriteLine($"{firstFlt} / {secondFlt} = {firstFlt / secondFlt}");
