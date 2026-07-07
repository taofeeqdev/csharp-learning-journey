Console.WriteLine("Hello, Taofeeq!");

// Strings
String firstFriend = "     Ummul    ";
firstFriend = firstFriend.Trim();

String secondFriend = "     Atiyyah    ";

Console.WriteLine($"My friends are {firstFriend} {secondFriend.Trim()}.");

String thirdFriend = "Uth";
String fourthFriend = "Needles";

String friends = $"My new friends are {thirdFriend} and {fourthFriend}.";

Console.WriteLine(friends);
String NewFriends = friends.Replace("Uth", "Atiyyah");

Console.WriteLine(NewFriends);
Console.WriteLine(NewFriends.ToUpper());
Console.WriteLine(NewFriends.StartsWith("You"));


// Numbers
int a = 15;
int b = 7;
int c = a + b;
Console.WriteLine(c);

int firstNumber = 2100000000;
int secondNumber = 1900000000;
long thirdNumber = (long)firstNumber + (long)secondNumber;
Console.WriteLine(thirdNumber);

double d = 4.3;    // Natural type
float e = 3.1f;
double f = d + e;
Console.WriteLine(f);

decimal g = 4.3M;   // Explicit type
decimal h = 3.1M;
decimal i = g + h;
Console.WriteLine($"The answer is {i}");


// Branching and ifs
int j = 15;
int k = 7;
if (j + k > 20)
{
   Console.WriteLine("The answer is GREATER than 20");
}
else
{
    Console.WriteLine("The answer is LESS than 20");
}

if((j + k > 20) && (j == k))
{
    Console.WriteLine("The answer is GREATER than 20 and j is equal to k");
}
else
{
    Console.WriteLine("The answer is LESS than 20 or j is NOT equal to k");
}