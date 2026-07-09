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

int x = 15;
long y = x;                        // Implicit conversion from int to long
short w = (short)x;                // Explicit conversion from int to short
short z = (short)((short)x + (short)y);
Console.WriteLine($"Short W is int to short: {w}");
Console.WriteLine($"Short Z is int x and long y to short: {z}");

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


// Loops
int counter = 0;
counter ++;
Console.WriteLine($"Counter is {counter}");
counter ++;
Console.WriteLine($"Counter is {counter}");
counter ++;
Console.WriteLine($"Counter is {counter}");
counter ++;
Console.WriteLine($"Counter is {counter}");

int count = 0;
// while loop
while (count < 5)
{
    Console.WriteLine($"Count is {count}");
    count++;
}

// do while loop
do
{
    Console.WriteLine($"Count is {count}");
    count++;
} while (count < 5);

// for loop
for (int index = 0; index < 5; index++)
{
    if(index == 3)
    {
        Console.WriteLine("Index is 3");
    }
}

// Reusable code with methods
Console.WriteLine(FeetToInches(30));
Console.WriteLine(FeetToInches(100));

int FeetToInches(int feet)
{
    return feet * 12;
}

Console.WriteLine(FeetToInches(22));