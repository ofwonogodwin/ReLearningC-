// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Am Now Understanding C#");
string firstFriend = "Ojara";
string secondFriend = "Kevin";
int age = 22;
int ages = 20;
float w1 = 60.5f;
float w2 = 65.2f;

Console.WriteLine($"My friends are {firstFriend.ToUpper()} and {secondFriend}");
Console.WriteLine($"{firstFriend.ToUpper()} is {age} years old and {secondFriend.ToLower()} is {ages} years old");
Console.WriteLine($"{firstFriend} weighs {w1} kgs and {secondFriend} weighs {w2} kgs ");
//Trimming Strings
string soda = "       Fanta       ";
Console.WriteLine(soda.Trim().Replace("Fanta","Mirinda").ToLower());

