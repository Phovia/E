using System.Security;

string[] availableClasses = {"Soldier", "Medic", "Thief"};

string[] availableChoises = {"Yes", "No"};

Console.WriteLine("Welcome, before we start I would like you to tell me about yourself");
Console.WriteLine("Tell me, what is your name?");
Console.WriteLine("Enter your name");
string GetName = Console.ReadLine();

Console.WriteLine ($"Is your name {GetName}?");

Console.WriteLine ("Yes");
Console.WriteLine ("No");

