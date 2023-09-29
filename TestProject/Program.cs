// See https://aka.ms/new-console-template for more information

Random Dice = new Random();
int zeroRoll = Dice.Next(2,5);
Console.WriteLine(zeroRoll + "first");

int roll = new Random().Next(1,7);
Console.WriteLine(roll);